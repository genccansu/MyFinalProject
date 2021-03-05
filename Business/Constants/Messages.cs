using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string ProductsListed = "Ürünler listelendi.";

        public static string ProductCountOfCategoryError ="Bir categoryde en fazla 10 ürün olabiir.";
        public static string ProductNameAlreadyExists = "Bu isimde ürün var.";

        public static string CategoryLimitExceded = "Category Limiti aşıldığı için yeni ürün eklenmez";
    }
}
