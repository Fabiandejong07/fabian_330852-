using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Application.Interfaces;
using Warehouse.Domain.Entities;

namespace Warehouse.Infrastructure.Repositories
{
    /// <summary>
    /// Communication repositiry.
    /// </summary>
    public class CommunicationRepository : Repository<CommunicationEntity>, ICommunicationRepository
    {
        /// <summary>
        /// Dependency of DbContext.
        /// </summary>
        public new WarehouseDbContext Context { get; }

        public new ILogger<CommunicationRepository> Logger { get; }

        /// <summary>
        /// CommunicationRepository constructor. 
        /// </summary>
        /// <param name="context"></param>
        public CommunicationRepository(WarehouseDbContext context, ILogger<CommunicationRepository> logger) : base(context, logger)
        {
            Context = context;
            Logger = logger;
        }
    }
}
