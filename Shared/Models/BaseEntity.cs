using System;
using System.Collections.Generic;
using System.Text;

namespace MarketAppDotNet.Shared.Models
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }
    }
}