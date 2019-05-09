using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS_Shop.Data.Infrastructure
{
    public class Disposable : IDisposable //IDisposable 1 interface có sẵn của c# cho phép nhưng class kế thừa từ nó cài đặt phương thức tự động hủy
    {
        private bool isDisposed;

        ~Disposable() //khi gọi hàm hủy 
        {
            Dispose(false); 
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); //thu hoạch bộ nhớ
        }
        private void Dispose(bool disposing)
        {
            if(!isDisposed && disposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }
        protected virtual void DisposeCore()
        {

        }


    }
}
