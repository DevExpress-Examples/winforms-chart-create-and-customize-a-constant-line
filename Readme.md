<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128572485/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1370)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ConstLines/Form1.cs) (VB: [Form1.vb](./VB/ConstLines/Form1.vb))
<!-- default file list end -->
# How to add a constant line to an axis


This example demonstrates how a [constant line](https://docs.devexpress.com/WindowsForms/5783/controls-and-libraries/chart-control/axes/constant-lines) can be created and customized at runtime.

Since constant lines belong to a diagram's [axis](https://docs.devexpress.com/WindowsForms/5779/controls-and-libraries/chart-control/diagram/axes), first it's required to cast your [diagram](https://docs.devexpress.com/WindowsForms/5778/controls-and-libraries/chart-control/diagram) object to the appropriate diagram's type. After that, it's possible to access axes and manage their constant lines collection.
