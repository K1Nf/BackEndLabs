// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Performance", "CA1862:Используйте перегрузки метода \"StringComparison\" для сравнения строк без учета регистра", Justification = "<Ожидание>", Scope = "member", Target = "~M:BackEndLabs.Controllers.RequestController.GetAllRequestLogs(System.Nullable{System.Int32},System.Nullable{System.Int32},BackEndLabs.Extensions.RequestLogsSortFilter)~System.Threading.Tasks.Task{Microsoft.AspNetCore.Mvc.ActionResult}")]
[assembly: SuppressMessage("Interoperability", "CA1416:Проверка совместимости платформы", Justification = "<Ожидание>", Scope = "member", Target = "~M:BackEndLabs.Controllers.FileController.LoadFile(Microsoft.AspNetCore.Http.IFormFile)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Interoperability", "CA1416:Проверка совместимости платформы", Justification = "<Ожидание>", Scope = "member", Target = "~M:BackEndLabs.Controllers.FileController.LoadFile(Microsoft.AspNetCore.Http.IFormFile)~System.Threading.Tasks.Task{Microsoft.AspNetCore.Mvc.IActionResult}")]
[assembly: SuppressMessage("Interoperability", "CA1416:Проверка совместимости платформы", Justification = "<Ожидание>", Scope = "member", Target = "~M:BackEndLabs.Controllers.FileController.GetArchiveFile~System.Threading.Tasks.Task")]
