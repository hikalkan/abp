# ASP.NET Boilerplate

AppVeyor: [![Build status](https://ci.appveyor.com/api/projects/status/tvad583r9lbimxh4?svg=true)](https://ci.appveyor.com/project/hikalkan/aspnetboilerplate) Gitter chat: [![Gitter](https://img.shields.io/gitter/room/nwjs/nw.js.svg)](https://gitter.im/aspnetboilerplate/aspnetboilerplate)

## What is ABP?

ASP.NET Boilerplate is a general purpose **application framework** especially designed for new modern web applications. It uses already **familiar tools** and implements **best practices** arround them to provide you a **SOLID development experience**.

###### Modular Design

Designed as <a href="https://aspnetboilerplate.com/Pages/Documents/Module-System" target="_blank">**modular**</a> and **extensible**. Provides infrastructure to build your own modules too.

###### Multi Tenancy

**SaaS** applications made easy! Integrated <a href="https://aspnetboilerplate.com/Pages/Documents/Multi-Tenancy" target="_blank">multi-tenancy</a> from database to UI.

###### Well Documented

Compherensive <a href="https://aspnetboilerplate.com/Pages/Documents" target="_blank">**documentation**</a> and jump start tutorials.

## How It Works

Don't Repeat Yourself! ASP.NET Boilerplate automates common software development tasks by convention. You focus your business code.

![ASP.NET Boilerplate](doc/img/abp-concerns.png)

See <a href="https://aspnetboilerplate.com/Pages/Documents/Introduction" target="_blank">introduction</a> document for details.

## Layered Architecture

ABP provides a layered architectural model based on **Domain Driven Design**. Provides a **SOLID** model for your application.

![NLayer Architecture](doc/img/abp-nlayer-architecture.png)

See <a href="https://aspnetboilerplate.com/Pages/Documents/NLayer-Architecture" target="_blank">NLayer Architecture</a> document for details.

## Startup Templates

Create your solution based on free or premium startup templates. Either with an Angular Single-Page Application or Classic MVC & jQuery architecture.

![](doc/img/module-zero-core-template.png)

<a href="https://aspnetboilerplate.com/Templates" target="_blank">Create your project now!</a>

## Nuget Packages

ASP.NET Boilerplate is distributed as nuget packages.

|Package|Status|
|:------|:-----:|
|Abp|[![NuGet version](https://badge.fury.io/nu/Abp.svg)](https://badge.fury.io/nu/Abp)|
|Abp.AspNetCore|[![NuGet version](https://badge.fury.io/nu/Abp.AspNetCore.svg)](https://badge.fury.io/nu/Abp.AspNetCore)|
|Abp.Web.Common|[![NuGet version](https://badge.fury.io/nu/Abp.Web.Common.svg)](https://badge.fury.io/nu/Abp.Web.Common)|
|Abp.Web|[![NuGet version](https://badge.fury.io/nu/Abp.Web.svg)](https://badge.fury.io/nu/Abp.Web)|
|Abp.Web.Mvc|[![NuGet version](https://badge.fury.io/nu/Abp.Web.Mvc.svg)](https://badge.fury.io/nu/Abp.Web.Mvc)|
|Abp.Web.Api|[![NuGet version](https://badge.fury.io/nu/Abp.Web.Api.svg)](https://badge.fury.io/nu/Abp.Web.Api)|
|Abp.Web.Api.OData|[![NuGet version](https://badge.fury.io/nu/Abp.eb.Api.OData.svg)](https://badge.fury.io/nu/Abp.Web.Api.OData)|
|Abp.Web.Resources|[![NuGet version](https://badge.fury.io/nu/Abp.Web.Resources.svg)](https://badge.fury.io/nu/Abp.Web.Resources)|
|Abp.Web.SignalR|[![NuGet version](https://badge.fury.io/nu/Abp.Web.SignalR.svg)](https://badge.fury.io/nu/Abp.Web.SignalR)|
|Abp.Owin|[![NuGet version](https://badge.fury.io/nu/Abp.Owin.svg)](https://badge.fury.io/nu/Abp.Owin)|
|Abp.EntityFramework.Common|[![NuGet version](https://badge.fury.io/nu/Abp.EntityFramework.Common.svg)](https://badge.fury.io/nu/Abp.EntityFramework.Common)|
|Abp.EntityFramework|[![NuGet version](https://badge.fury.io/nu/Abp.EntityFramework.svg)](https://badge.fury.io/nu/Abp.EntityFramework)|
|Abp.EntityFramework.GraphDiff|[![NuGet version](https://badge.fury.io/nu/Abp.EntityFramework.GraphDiff.svg)](https://badge.fury.io/nu/Abp.EntityFramework.GraphDiff)|
|Abp.EntityFrameworkCore|[![NuGet version](https://badge.fury.io/nu/Abp.EntityFrameworkCore.svg)](https://badge.fury.io/nu/Abp.EntityFrameworkCore)|
|Abp.NHibernate|[![NuGet version](https://badge.fury.io/nu/Abp.NHibernate.svg)](https://badge.fury.io/nu/Abp.NHibernate)|
|Abp.Dapper|[![NuGet version](https://badge.fury.io/nu/Abp.Dapper.svg)](https://badge.fury.io/nu/Abp.Dapper)|
|Abp.FluentMigrator|[![NuGet version](https://badge.fury.io/nu/Abp.FluentMigrator.svg)](https://badge.fury.io/nu/Abp.FluentMigrator)|
|Abp.AspNetCore|[![NuGet version](https://badge.fury.io/nu/Abp.AspNetCore.svg)](https://badge.fury.io/nu/Abp.AspNetCore)|
|Abp.AutoMapper|[![NuGet version](https://badge.fury.io/nu/Abp.AutoMapper.svg)](https://badge.fury.io/nu/Abp.AutoMapper)|
|Abp.HangFire|[![NuGet version](https://badge.fury.io/nu/Abp.HangFire.svg)](https://badge.fury.io/nu/Abp.HangFire)|
|Abp.HangFire.AspNetCore|[![NuGet version](https://badge.fury.io/nu/Abp.HangFire.AspNetCore.svg)](https://badge.fury.io/nu/Abp.HangFire.AspNetCore)|
|Abp.Castle.Log4Net|[![NuGet version](https://badge.fury.io/nu/Abp.Castle.Log4Net.svg)](https://badge.fury.io/nu/Abp.Castle.Log4Net)|
|Abp.RedisCache|[![NuGet version](https://badge.fury.io/nu/Abp.RedisCache.svg)](https://badge.fury.io/nu/Abp.RedisCache)|
|Abp.RedisCache.ProtoBuf|[![NuGet version](https://badge.fury.io/nu/Abp.RedisCache.ProtoBuf.svg)](https://badge.fury.io/nu/Abp.RedisCache.ProtoBuf)|
|Abp.MailKit|[![NuGet version](https://badge.fury.io/nu/Abp.MailKit.svg)](https://badge.fury.io/nu/Abp.MailKit)|
|Abp.Quartz|[![NuGet version](https://badge.fury.io/nu/Abp.Quartz.svg)](https://badge.fury.io/nu/Abp.Quartz)|
|Abp.TestBase|[![NuGet version](https://badge.fury.io/nu/Abp.TestBase.svg)](https://badge.fury.io/nu/Abp.TestBase)|
|Abp.AspNetCore.TestBase|[![NuGet version](https://badge.fury.io/nu/Abp.AspNetCore.TestBase.svg)](https://badge.fury.io/nu/Abp.AspNetCore.TestBase)|

## Links

* Web site & Documentation: https://aspnetboilerplate.com
* Questions & Answers: https://stackoverflow.com/questions/tagged/aspnetboilerplate?sort=newest

## License

[MIT](LICENSE).
