let deferredPrompt = null;

function isInstalled() {
  return window.matchMedia('(display-mode: standalone)').matches
      || window.navigator.standalone === true;
}

export function initInstallPrompt() {
  // Already installed → do not show button
  if (isInstalled()) return { available: false, reason: "installed" };

  window.addEventListener("beforeinstallprompt", (e) => {
    e.preventDefault();
    deferredPrompt = e;
    window.dispatchEvent(new Event("pwa-install-available"));
  }, { once: true });

  window.addEventListener("appinstalled", () => {
    deferredPrompt = null;
    window.dispatchEvent(new Event("pwa-installed"));
  }, { once: true });

  return { available: false, reason: "waiting" };
}

export function canPromptInstall() {
  if (isInstalled()) return false;
  return deferredPrompt !== null;
}

export async function showInstallPrompt() {
  if (!deferredPrompt) return false;

  deferredPrompt.prompt();
  const choice = await deferredPrompt.userChoice;
  deferredPrompt = null;
  return choice?.outcome === "accepted";
}

export function isAppInstalled() {
  return isInstalled();
}