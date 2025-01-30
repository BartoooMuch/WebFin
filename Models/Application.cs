using System;
using System.ComponentModel.DataAnnotations;

namespace WebFin.Models
{
    public class Application
    {
        public int Id { get; set; }

        [Required]
        public string ApplicantName { get; set; }  // 📌 Başvuranın Adı

        [Required]
        [EmailAddress]
        public string Email { get; set; }  // 📌 Başvuranın E-posta Adresi

        [Required]
        public int JobPostId { get; set; }  // 📌 Hangi iş ilanına başvurduğunu belirten ID

        public JobPost JobPost { get; set; }  // 📌 Foreign Key - İş İlanı ile Bağlantı

        [Required]
        public DateTime AppliedOn { get; set; } = DateTime.Now;  // 📌 Başvuru tarihi
    }
}
