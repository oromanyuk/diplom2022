//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace logistic
{
    using System;
    using System.Collections.Generic;
    
    public partial class orders
    {
        public int id_order { get; set; }
        public int id_drivers { get; set; }
        public int id_client { get; set; }
        public int id_transport { get; set; }
        public string destination { get; set; }
        public int cargo_size { get; set; }
        public int lenght_path { get; set; }
        public int price { get; set; }
        public string cargo_type { get; set; }
        public string date { get; set; }
        public int id_status { get; set; }
    
        public virtual clients clients { get; set; }
        public virtual drivers drivers { get; set; }
        public virtual status_orders status_orders { get; set; }
        public virtual transport transport { get; set; }
    }
}
