let deferredPrompt = null;

function isInstalled() {
    return window.matchMedia('(display-mode: standalone)').matches
        || window.navigator.standalone === true;
}

export function initInstallPrompt() {

    if (isInstalled()) {
        return false; // Already installed → hide button
    }

    window.addEventListener('beforeinstallprompt', (e) => {
        e.preventDefault();
        deferredPrompt = e;
    });

    return true;
}

export async function showInstallPrompt() {
    if (!deferredPrompt) return;

    deferredPrompt.prompt();
    await deferredPrompt.userChoice;
    deferredPrompt = null;
}

window.addEventListener('appinstalled', () => {
    deferredPrompt = null;
});