# WKSorter

简体中文 · [English](README.en.md)

![Windows x64](https://img.shields.io/badge/Windows-x64-0078D4?style=flat)
[![最新发布版](https://img.shields.io/github/v/release/WuWorks/WKSorter?style=flat&label=Release&color=007EC6)](https://github.com/WuWorks/WKSorter/releases/latest)
![C# / .NET 10](https://img.shields.io/badge/C%23-.NET%2010-512BD4?style=flat)
![WPF + WebView2](https://img.shields.io/badge/WPF-WebView2-007EC6?style=flat)
![CreamyUI](https://img.shields.io/badge/CreamyUI-UI%20Kit-52677D?style=flat)

WKSorter 是一款 Windows 文件整理与备份工具，支持按规则分类文件、配置自动整理任务，以及备份和恢复资料。

## 解决什么问题

- **文件分类耗时**：按规则整理混杂的文件，减少逐个移动和归类。
- **目录反复堆积**：自动处理持续新增的文件，减少重复清理。
- **备份依赖人工维护**：将重复备份纳入计划执行，并支持后续恢复。

## 主要功能

| 功能 | 说明 |
| --- | --- |
| 手动整理 | 预览分类结果与目标路径，确认后执行移动或复制。 |
| 自动整理 | 通过目录监听或计划任务执行文件整理。 |
| 备份与恢复 | 支持手动与定时备份、增量备份及恢复。 |

自动整理默认处理来源目录中的直接文件；已有子文件夹及其内容保持原有结构。

## 下载与运行

从 [GitHub Releases](https://github.com/WuWorks/WKSorter/releases/latest) 下载最新 Windows x64 安装包。

- **支持平台**：Windows x64。
- **运行环境**：Microsoft Edge WebView2 Runtime。缺失时，安装程序会尝试自动安装。

已安装用户可通过「关于 → 检查更新」获取新版本。

## 快速开始

1. 在「整理」页面选择来源目录和目标目录。
2. 点击「预览整理」，核对分类结果及目标路径。
3. 确认预览后执行整理。

## 反馈与建议

通过 [GitHub Issues](https://github.com/WuWorks/WKSorter/issues) 提交问题和建议，也可从应用内的「关于 → 提交反馈」打开。

报告问题时，请提供应用版本、Windows 版本及复现步骤。

## 许可与参考

WKSorter 仅限非商业使用，具体条款见 [使用许可](LICENSE.txt)。第三方组件许可可在应用内的「关于 → 许可信息」查看。

本仓库提供产品介绍、发行版本及 [学习参考](reference/)。参考目录展示部分 C# 实现，使用范围见许可文件。
