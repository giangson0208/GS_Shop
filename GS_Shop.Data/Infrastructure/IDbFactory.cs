using System;

namespace GS_Shop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable //giao tiếp khởi tạo đối tượng Entity(k khởi tạo trực tiếp mà thông qua Factory)
    {
        GS_ShopDbContext Init(); //chỉ cần phương thức này để init DbContext
    }
}