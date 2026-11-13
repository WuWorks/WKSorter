# WKSorter

[简体中文](README.md) · English

![Windows x64](https://img.shields.io/badge/Windows-x64-0078D4?style=flat)
[![Latest release](https://img.shields.io/github/v/release/WuWorks/WKSorter?style=flat&label=Release&color=007EC6)](https://github.com/WuWorks/WKSorter/releases/latest)
![C# / .NET 10](https://img.shields.io/badge/C%23-.NET%2010-512BD4?style=flat)
![WPF + WebView2](https://img.shields.io/badge/WPF-WebView2-007EC6?style=flat)
![CreamyUI](https://img.shields.io/badge/CreamyUI-UI%20Kit-52677D?style=flat)

WKSorter is a Windows utility for rule-based file organization, automated sorting, and file backup and restore.

## Problems addressed

- **Time-consuming file sorting**: Organize mixed files by rules to reduce moving and categorizing them one by one.
- **Recurring folder clutter**: Process incoming files automatically to reduce repeated manual cleanup.
- **Backups that require manual upkeep**: Schedule recurring backups and support recovery when needed.

## Features

| Feature | Description |
| --- | --- |
| Manual sorting | Preview classification results and destination paths before moving or copying files. |
| Automatic sorting | Run sorting tasks using folder monitoring or a schedule. |
| Backup and restore | Create manual or scheduled backups, with incremental backup and restore. |

By default, automatic sorting processes files directly within the source folder. Existing subfolders and their contents retain their structure.

## Download and requirements

Download the latest Windows x64 installer from [GitHub Releases](https://github.com/WuWorks/WKSorter/releases/latest).

- **Platform**: Windows x64.
- **Runtime**: Microsoft Edge WebView2 Runtime. If missing, the installer attempts to install the runtime automatically.

Existing users can obtain updates through **About → Check updates**.

## Quick start

1. Select the source and destination folders on the **Organize** page.
2. Click **Preview sorting** and review the classification results and destination paths.
3. Confirm the preview and run the sorting task.

## Feedback

Submit issues and suggestions through [GitHub Issues](https://github.com/WuWorks/WKSorter/issues), also accessible through **About → Submit feedback** in the app.

When reporting an issue, include the app version, Windows version, and steps to reproduce it.

## License and references

WKSorter is for noncommercial use only. See the [license](LICENSE.txt) for the full terms. Third-party licenses are available under **About → Licenses** in the app.

This repository provides product information, releases, and [code references](reference/). The reference directory presents selected C# implementations; see the license for permitted use.
