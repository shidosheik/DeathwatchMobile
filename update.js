let registration = null;
let dotNetRef = null;

/* ----------------------------
   Blazor callback bridge
-----------------------------*/

function onUpdateAvailable() {
  dotNetRef?.invokeMethodAsync("NotifyUpdateAvailable");
}

export function registerUpdateCallbacks(ref) {
  dotNetRef = ref;
  window.addEventListener("pwa-update-available", onUpdateAvailable);
}

export function unregisterUpdateCallbacks() {
  window.removeEventListener("pwa-update-available", onUpdateAvailable);
  dotNetRef = null;
}

/* ----------------------------
   Service worker update logic
-----------------------------*/

export async function initUpdateListener() {
  if (!("serviceWorker" in navigator)) return false;

  registration = await navigator.serviceWorker.getRegistration();
  if (!registration) return false;

  // If update already waiting
  if (registration.waiting) {
    window.dispatchEvent(new Event("pwa-update-available"));
    return true;
  }

  // Detect new SW installing
  registration.addEventListener("updatefound", () => {
    const newWorker = registration.installing;
    if (!newWorker) return;

    newWorker.addEventListener("statechange", () => {
      if (newWorker.state === "installed" && navigator.serviceWorker.controller) {
        window.dispatchEvent(new Event("pwa-update-available"));
      }
    });
  });

  return false;
}

export async function activateUpdateAndReload() {
  if (!registration) {
    registration = await navigator.serviceWorker.getRegistration();
  }

  if (registration?.waiting) {
    registration.waiting.postMessage({ type: "SKIP_WAITING" });
  }

  // Reload once new service worker takes control
  navigator.serviceWorker.addEventListener("controllerchange", () => {
    window.location.reload();
  });
}