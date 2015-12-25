﻿using Orders.com.BLL.Domain;
using Orders.com.BLL.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Orders.com.Web.MVC.ViewModels
{
    public class OrderItemViewModel : ViewModel<OrderItem>
    {
        public long OrderID
        {
            get { return Entity.OrderID; }
            set { Entity.OrderID = value; }
        }

        [Display(Name = "Product")]
        public string ProductName { get; set; }

        [Display(Name = "In Stock")]
        public decimal InStock { get; set; }

        public long ProductID
        {
            get { return Entity.ProductID; }
            set { Entity.ProductID = value; }
        }

        public decimal Quantity
        {
            get { return Entity.Quantity; }
            set { Entity.Quantity = value; }
        }

        public decimal Amount
        {
            get { return Entity.Amount; }
            set { Entity.Amount = value; }
        }

        public decimal Price
        {
            get { return Entity.Price; }
            set { Entity.Price = value; }
        }

        public string Status
        {
            get { return Entity.OrderStatus()?.Name; }
        }

        [Display(Name = "Submitted On")]
        public DateTime? SubmittedOn
        {
            get { return Entity.SubmittedDate; }
        }

        [Display(Name = "Shipped On")]
        public DateTime? ShippedOn 
        {
            get { return Entity.ShippedDate; }
        }

        public long ID
        {
            get { return Entity.ID; }
            set { Entity.ID = value; }
        }
    }
}