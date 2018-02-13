﻿using System;
using System.Collections.Generic;
using System.Linq;
using Xe.Gateway.data.Contract;
using XeGateWay.Domain;

namespace XeGateway.Data.EFRepository
{
    public class XeSourceRepository : IXeSourceRepository
    {
        private readonly SqlDBContext _ctx;   
        public XeSourceRepository(SqlDBContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(XeGatewaySource src)
        {
            _ctx.Source.Add(src);
        }

        public XeGatewaySource get(Int64 id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<XeGatewaySource> getAll()
        {
          return  _ctx.Source.ToList();
        }

        public void Remove(XeGatewaySource src)
        {
            throw new NotImplementedException();
        }
    }
}