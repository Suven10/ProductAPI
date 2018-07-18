using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
    public class Product1
    {
        string _guProductId;
        [Key]
        public string GuProductId {
            get
            {
                return _guProductId;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();
                _guProductId = value;
            }
        }

        string _productName;
        public string ProductName {
            get
            {
                return _productName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();
                _productName = value;
            }
        }

        string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();
                _description = value;
            }
        }

        string _code;
        public string Code
        {
            get
            {
                return _code;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();
                _code = value;
            }
        }

        string _category;
        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();
                _category = value;
            }
        }

        string _brand;
        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();
                _brand = value;
            }
        }

        string _image;
        public string Image
        {
            get
            {
                return _image;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();
                _image = value;
            }
        }
        public Status ProdStatus { get; set; }

        int _unitQty;
        public int UnitQty
        {
            get
            {
                return _unitQty;
            }
            set
            {
                if (value<=0)
                    throw new ArgumentNullException();
                _unitQty = value;
            }
        }

        decimal _unitPrice;
        public decimal UnitPrice
        {
            get
            {
                return _unitPrice;
            }
            set
            {
                if (value<=0)
                    throw new ArgumentNullException();
                _unitPrice = value;
            }
        }

        public Status Taxable { get; set; }
        
        string _guTaxGrpId;
        public string GuTaxGrpId
        {
            get
            {
                return _guTaxGrpId;
            }
            set
            {
                if (Status.Active==0 && string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();
                _guTaxGrpId = value;
            }
        }

        public Status Sku { get; set; } 

        string _costPrice;
        public string CostPrice
        {
            get
            {
                return _costPrice;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();
                _costPrice = value;
            }
        }

        int _minStock;
        public int MinStock
        {
            get
            {
                return _minStock;
            }
            set
            {
                if (value<=0)
                    throw new ArgumentNullException();
                _minStock = value;
            }
        }

        DateTime _createDate;
        public DateTime CreateDate
        {
            get
            {
                return _createDate;
            }
            set
            {
                if (value==null)
                    throw new ArgumentNullException();
                _createDate = value;
            }
        }

        string _createUser;
        public string CreateUser
        {
            get
            {
                return _createUser;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();
                _createUser = value;
            }
        }

        public enum Status
        {
            Active,
            InActive
        }
    }
}
