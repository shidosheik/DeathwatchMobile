# Deathwatch Mobile

A Progressive Web App (PWA) character creator and tracker for **Warhammer 40,000: Deathwatch (FFG d100 system)**.

Built with **Blazor WebAssembly (.NET 9)** and deployed via **GitHub Pages**.

---

## 🚀 Live App

🔗 https://shidosheik.github.io/DeathwatchMobile/

Install on Android:
- Open the link in Chrome
- Tap ⋮ menu
- Select **Install App**

The app works offline once installed.

---

## ✨ Features

### Character Management
- Create and edit Deathwatch characters
- Rank and Renown tracking
- Persistent local storage (browser-based)

### Characteristics
- Base + Advances + Power Assist
- Automatic total and bonus calculation
- Derived stat bonuses

### Skills System
- Governing characteristic selection
- Training levels (Untrained, Trained, +10, +20)
- Live target number calculation
- Filtering (search, governing stat, trained-only, sort)
- Built-in d100 dice roller with Degrees of Success/Failure

### Experience System
- XP Earned / Spent / Remaining auto-calculation
- XP log with timestamps
- Persistent storage

---

## 🧠 Technology Stack

- .NET 9
- Blazor WebAssembly
- PWA (Service Worker enabled)
- GitHub Pages deployment
- GitHub Actions CI/CD pipeline

---

## 🔄 Deployment

This project automatically deploys to the `gh-pages` branch via GitHub Actions.

On every push to `main`:

1. The app is built in Release mode
2. Base href is adjusted for GitHub Pages
3. `.nojekyll` is added
4. The site is deployed to `gh-pages`

No manual copying required.

---

## ⚠️ Data Storage

All character data is stored in browser `localStorage`.

- Data does not sync between devices.
- Clearing site storage will delete characters.
- Future versions may support export/import backup.

---

## 🛠 Development

To run locally:

```bash
dotnet restore
dotnet run