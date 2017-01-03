// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Resource.Fluent.Core
{
    using CollectionActions;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Base class for independent child collection class.
    /// (Internal use only).
    /// </summary>
    /// <typeparam name="">The individual resource type returned.</typeparam>
    /// <typeparam name="Impl">The individual resource implementation.</typeparam>
    /// <typeparam name="Inner">The wrapper inner type.</typeparam>
    /// <typeparam name="InnerCollection">The inner type of the collection object.</typeparam>
    /// <typeparam name="Manager">The manager type for this resource provider type.</typeparam>
    ///GENTHASH:Y29tLm1pY3Jvc29mdC5henVyZS5tYW5hZ2VtZW50LnJlc291cmNlcy5mbHVlbnRjb3JlLmFybS5jb2xsZWN0aW9uLmltcGxlbWVudGF0aW9uLkluZGVwZW5kZW50Q2hpbGRyZW5JbXBs
    public abstract partial class IndependentChildrenImpl<T, ImplT, InnerT, InnerCollectionT, ManagerT> :
        CreatableResources<T, ImplT, InnerT>,
        ISupportsGettingById<T>,
        ISupportsGettingByParent<T>,
        ISupportsListingByParent<T>,
        ISupportsDeletingById,
        ISupportsDeletingByParent
        where T : class, IHasId
        where ImplT : T
    {
        protected InnerCollectionT innerCollection;
        protected ManagerT manager;

        public IndependentChildrenImpl(InnerCollectionT innerCollection, ManagerT manager)
        {
            this.innerCollection = innerCollection;
            this.manager = manager;
        }

        ///GENMHASH:5002116800CBAC02BBC1B4BF62BC4942:EC62A0BF293C71A310E2FDC965B8DA29
        public T GetById(string id)
        {
            return GetByIdAsync(id).GetAwaiter().GetResult();
        }

        public async Task<T> GetByIdAsync(string id, CancellationToken cancellationToken = default(CancellationToken))
        {
            ResourceId resourceId = ResourceId.ParseResourceId(id);

            return await GetByParentAsync(resourceId.ResourceGroupName, resourceId.Parent.Name, resourceId.Name);
        }

        ///GENMHASH:B1F9F82090ABF692D9645AE6B2D732EE:B8247A96B5B602D0F01FFC494377AA87
        public T GetByParent(IGroupableResource parentResource, string name)
        {
            return GetByParent(parentResource.ResourceGroupName, parentResource.Name, name);
        }

        public T GetByParent(string resourceGroup, string parentName, string name)
        {
            return GetByParentAsync(resourceGroup, parentName, name).GetAwaiter().GetResult();
        }

        public async Task<T> GetByParentAsync(IGroupableResource parentResource, string name, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await GetByParentAsync(parentResource.ResourceGroupName, parentResource.Name, name);
        }

        ///GENMHASH:A0A10EB2FF1149F056003612DA902E09:D8BC76ED0E6FF85C69301F568869AE3D
        public PagedList<T> ListByParent(IGroupableResource parentResource)
        {
            return ListByParent(parentResource.ResourceGroupName, parentResource.Name);
        }

        public PagedList<T> ListByParent(string resourceGroupName, string parentName)
        {
            return ListByParentAsync(resourceGroupName, parentName).GetAwaiter().GetResult();
        }

        public async Task<PagedList<T>> ListByParentAsync(IGroupableResource parentResource, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await ListByParentAsync(parentResource.ResourceGroupName, parentResource.Name);
        }

        public override void DeleteById(string id)
        {
            DeleteByIdAsync(id).Wait();
        }

        ///GENMHASH:4D33A73A344E127F784620E76B686786:45501AE2D88C8DB770F13846C7DD5857
        public override async Task DeleteByIdAsync(string id, CancellationToken cancellationToken = default(CancellationToken))
        {
            ResourceId resourceId = ResourceId.ParseResourceId(id);

            await DeleteByParentAsync(resourceId.ResourceGroupName, resourceId.Parent.Name, resourceId.Name);
        }

        ///GENMHASH:60749B1ABD9ABFE5DA6F2DE13BAF999E:84B11042D38049C213681791B3D8EAEB
        public void DeleteByParent(string groupName, string parentName, string name)
        {
            Task.WaitAll(DeleteByParentAsync(groupName, parentName, name));
        }

        public abstract Task<T> GetByParentAsync(string resourceGroup, string parentName, string name, CancellationToken cancellationToken = default(CancellationToken));

        public abstract Task<PagedList<T>> ListByParentAsync(string resourceGroupName, string parentName, CancellationToken cancellationToken = default(CancellationToken));

        public abstract Task DeleteByParentAsync(string groupName, string parentName, string name, CancellationToken cancellationToken = default(CancellationToken));
    }
}