// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
class user
{
    public string FirstName { get; set; }
    public int LastName { get; set; }
}
abstract class AbstractclassUser
{
    public int MyProperty { get; set; }
    public abstract int MyProperty2 { get; set; }
    public abstract void Add(user user);
    public void Remove(user user)
    {
        //کد های حذف
    }
    public virtual void Edit(user user)
    {
        //کدهای ویرایش
    }
}