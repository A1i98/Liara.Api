// ایجاد یک نمونه از کلاس Liara.Api.Liara با استفاده از توکن
var liara = new Liara.Api.Liara("token");

// ارسال درخواست GET به سرویس GetMe و ذخیره نتیجه در getMe
var getMe = await liara.GetMe();

// چاپ مقدار balance کاربر در خروجی
Console.WriteLine(getMe.User?.Balance);