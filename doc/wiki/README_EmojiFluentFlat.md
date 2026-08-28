# AntdUI Emoji 资源库

## 📦 简介

AntdUI Emoji 资源库是基于 Microsoft Fluent UI Emoji 设计的一套现代化 Emoji 图标集，为 AntdUI WinForm 应用提供丰富的表情符号支持，打破传统桌面应用的黑白界限，增加界面趣味性和表现力。

## 🔗 官方仓库

Emoji 资源来源于 Microsoft 官方 Fluent UI Emoji 仓库：
https://github.com/microsoft/fluentui-emoji

## 🚀 使用方法

在应用程序初始化之前，即可通过以下代码将 Fluent Flat Emoji 资源设置到 AntdUI 中：

```csharp
AntdUI.SvgDb.Emoji = AntdUI.FluentFlat.Emoji;
```

## 📋 注意事项

1. 确保在应用程序启动初期就设置 Emoji 资源，建议在 `Main` 方法或应用程序初始化阶段执行
2. 设置后，所有 AntdUI 控件都会自动使用新的 Emoji 资源
3. 可以根据需要随时切换不同的 Emoji 资源库
4. Emoji 资源较大，会增加应用程序的内存占用，建议根据实际需求选择是否使用

---

# AntdUI Emoji Resource Library

## 📦 Introduction

AntdUI Emoji Resource Library is a modern Emoji icon set based on Microsoft Fluent UI Emoji design, providing rich emoji support for AntdUI WinForm applications. It breaks the black and white boundaries of traditional desktop applications, adding fun and expressiveness to the interface.

## 🔗 Official Repository

Emoji resources are sourced from Microsoft's official Fluent UI Emoji repository:
https://github.com/microsoft/fluentui-emoji

## 🚀 Usage

Before application initialization, you can set the Fluent Flat Emoji resources to AntdUI through the following code:

```csharp
AntdUI.SvgDb.Emoji = AntdUI.FluentFlat.Emoji;
```

## 📋 Notes

1. Make sure to set the Emoji resources at the beginning of the application startup, it is recommended to execute in the `Main` method or application initialization phase
2. After setting, all AntdUI controls will automatically use the new Emoji resources
3. You can switch between different Emoji resource libraries at any time as needed
4. Emoji resources are large and will increase the memory usage of the application, it is recommended to choose whether to use it according to actual needs   
