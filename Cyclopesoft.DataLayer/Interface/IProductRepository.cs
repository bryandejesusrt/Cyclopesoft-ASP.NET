using Cyclopesoft.DataLayer.Entities;

namespace Cyclopesoft.DataLayer.Interface
{
    public interface IProductRepository
    {
        void Save(Product product);
        void Update(Product product);
        void Remove(Product product);
        public Product GetProduct(int id);
        public bool ExistProduct(int id);
    }
}
