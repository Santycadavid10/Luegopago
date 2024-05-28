namespace Cuponera.Services
{
    public interface ICouponRepository
    {
         IEnumerable<Coupon> GetAll();
         Coupon GetById(int id);

         void add(Coupon coupon);

    }
}