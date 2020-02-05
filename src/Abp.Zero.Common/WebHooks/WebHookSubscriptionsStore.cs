﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Linq;

namespace Abp.Webhooks
{
    /// <summary>
    /// Implements <see cref="IWebhookSubscriptionsStore"/> using repositories.
    /// </summary>
    public class WebhookSubscriptionsStore : IWebhookSubscriptionsStore, ITransientDependency
    {
        private readonly IRepository<WebhookSubscriptionInfo, Guid> _webhookSubscriptionRepository;
        public IAsyncQueryableExecuter AsyncQueryableExecuter { get; set; }

        public WebhookSubscriptionsStore(IRepository<WebhookSubscriptionInfo, Guid> webhookSubscriptionRepository)
        {
            _webhookSubscriptionRepository = webhookSubscriptionRepository;
            AsyncQueryableExecuter = NullAsyncQueryableExecuter.Instance;
        }

        [UnitOfWork]
        public virtual Task<WebhookSubscriptionInfo> GetAsync(Guid id)
        {
            return _webhookSubscriptionRepository.GetAsync(id);
        }

        [UnitOfWork]
        public virtual WebhookSubscriptionInfo Get(Guid id)
        {
            return _webhookSubscriptionRepository.Get(id);
        }

        [UnitOfWork]
        public virtual async Task InsertAsync(WebhookSubscriptionInfo webhookInfo)
        {
            await _webhookSubscriptionRepository.InsertAsync(webhookInfo);
        }

        [UnitOfWork]
        public virtual void Insert(WebhookSubscriptionInfo webhookInfo)
        {
            _webhookSubscriptionRepository.Insert(webhookInfo);
        }

        [UnitOfWork]
        public virtual async Task UpdateAsync(WebhookSubscriptionInfo webhookSubscription)
        {
            await _webhookSubscriptionRepository.UpdateAsync(webhookSubscription);
        }

        [UnitOfWork]
        public virtual void Update(WebhookSubscriptionInfo webhookSubscription)
        {
            _webhookSubscriptionRepository.Update(webhookSubscription);
        }

        [UnitOfWork]
        public virtual async Task DeleteAsync(Guid id)
        {
            await _webhookSubscriptionRepository.DeleteAsync(id);
        }

        [UnitOfWork]
        public virtual void Delete(Guid id)
        {
            _webhookSubscriptionRepository.Delete(id);
        }

        [UnitOfWork]
        public virtual async Task<List<WebhookSubscriptionInfo>> GetAllSubscriptionsAsync(int? tenantId, string webhookDefinitionName)
        {
            return await _webhookSubscriptionRepository.GetAllListAsync(s =>
                s.TenantId == tenantId &&
                s.IsActive &&
                s.Webhooks.Contains("\"" + webhookDefinitionName + "\""));
        }

        [UnitOfWork]
        public virtual List<WebhookSubscriptionInfo> GetAllSubscriptions(int? tenantId, string webhookDefinitionName)
        {
            return _webhookSubscriptionRepository.GetAllList(s =>
               s.TenantId == tenantId &&
               s.IsActive &&
               s.Webhooks.Contains("\"" + webhookDefinitionName + "\""));
        }

        [UnitOfWork]
        public virtual Task<bool> IsSubscribedAsync(int? tenantId, string webhookName)
        {
            return AsyncQueryableExecuter.AnyAsync(_webhookSubscriptionRepository.GetAll()
                .Where(s =>
                    s.TenantId == tenantId &&
                    s.IsActive &&
                    s.Webhooks.Contains("\"" + webhookName + "\"")
                ));
        }

        [UnitOfWork]
        public virtual bool IsSubscribed(int? tenantId, string webhookName)
        {
            return _webhookSubscriptionRepository.GetAll()
                .Any(s =>
                    s.TenantId == tenantId &&
                    s.IsActive &&
                    s.Webhooks.Contains("\"" + webhookName + "\"")
                );
        }

        [UnitOfWork]
        public virtual Task<List<WebhookSubscriptionInfo>> GetAllSubscriptionsAsync(int? tenantId)
        {
            return _webhookSubscriptionRepository.GetAllListAsync(s => s.TenantId == tenantId);
        }

        [UnitOfWork]
        public virtual List<WebhookSubscriptionInfo> GetAllSubscriptions(int? tenantId)
        {
            return _webhookSubscriptionRepository.GetAllList(s => s.TenantId == tenantId);
        }
    }
}