public interface IRepository<T> {
    public IEnumerable<T> GetAll();
    public T GetById(int id);
    public void Update(T obj);
    public void Add(T obj);
    public void Delete(int id);
}