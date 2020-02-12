using PenelopePie.Model.WebApiDTO.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PenelopePie.Model.WebApiDTO
{
    public interface IWebApiDTO
    {
        // web api http fields and implementations
        void StampTransaction(WebApiInfraTag infra);
    }
}
