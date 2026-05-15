using MVC.Models;
namespace MVC.Controllers
{
    public class UserController
    {
        private m_userContext ucontext = new m_userContext();

        // READ
        public List<m_User> GetAllUsers()
        {
            return ucontext.GetAllUsers();
        }

        // CREATE
        public void AddUser(m_User user)
        {
            // Validasi inputan dari textBox
            if (string.IsNullOrWhiteSpace(user.nama))
            {
                throw new Exception("Nama tidak boleh kosong");
            }

            ucontext.AddUser(user);
        }

        // UPDATE
        public void UpdateUser(m_User user)
        {
            ucontext.UpdateUser(user);
        }

        // DELETE
        public void DeleteUser(int id)
        {
            if (id <= 0)
            {
                throw new Exception("ID user tidak valid");
            }

            ucontext.DeleteUser(id);
        }
    }
}