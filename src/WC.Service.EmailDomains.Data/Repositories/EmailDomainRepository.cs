﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sieve.Services;
using WC.Library.Data.Repository;
using WC.Service.EmailDomains.Data.Models;

namespace WC.Service.EmailDomains.Data.Repositories;

public class EmailDomainRepository<TDbContext>
    : RepositoryBase<EmailDomainRepository<TDbContext>, TDbContext, EmailDomainEntity>,
        IEmailDomainRepository
    where TDbContext : DbContext
{
    protected EmailDomainRepository(
        TDbContext context,
        ILogger<EmailDomainRepository<TDbContext>> logger,
        ISieveProcessor sieveProcessor)
        : base(context, logger, sieveProcessor)
    {
    }
}
