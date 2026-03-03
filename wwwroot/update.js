let registration = null;

export async function initUpdateListener() {
  if (!("serviceWorker" in navigator)) return false;

  registration = await navigator.serviceWorker.getRegistration();
  if (!registration) return false;

  // If there's already an update waiting, tell UI immediately
  if (registration.waiting) return true;

  // Listen for new SW installing
  registration.addEventListener("updatefound", () => {
    const newWorker = registration.installing;
    if (!newWorker) return;

    newWorker.addEventListener("statechange", () => {
      // When installed and there's an existing controller, an update is ready
      if (newWorker.state === "installed" && navigator.serviceWorker.controller) {
        window.dispatchEvent(new Event("pwa-update-available"));
      }
    });
  });

  // If an update becomes waiting later, notify
  navigator.serviceWorker.addEventListener("controllerchange", () => {
    // No-op here; reload will happen when we click button
  });

  return false;
}

export async function activateUpdateAndReload() {
  if (!registration) {
    registration = await navigator.serviceWorker.getRegistration();
  }
  if (registration?.waiting) {
    // Tell waiting SW to skip waiting
    registration.waiting.postMessage({ type: "SKIP_WAITING" });
  }
  // The controllerchange event will fire; reload to get new assets
  window.location.reload();
}