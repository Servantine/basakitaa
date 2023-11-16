using System.ComponentModel.DataAnnotations;

namespace basakitaa.Models
{
    public class User
    {
        public string id { get; set; }
        [Required(ErrorMessage = "Nama Harus Diisi")]
        public string nama { get; set; }
        [Required(ErrorMessage = "Jenis Kelamin harus diisi")]
        public string jeniskelamin { get; set; }
        [Required(ErrorMessage = "Tanggal lahir harus diisi")]
        public string tanggallahir { get; set; }
        [Required(ErrorMessage = "Alamat harus diisi")]
        public string alamat { get; set; }
        [Required(ErrorMessage = "Email harus diisi")]
        public string email { get; set; }
        [Required(ErrorMessage = "Password harus diisi")]
        public string password { get; set; }
    }
}
