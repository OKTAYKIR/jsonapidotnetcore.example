using JsonApiDotNetCore.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jsonapidotnetcore.example.Model
{
    public class User : Identifiable<string>
    {
        [Key]
        [Column("id")]
        public override string Id { get; set; }

        [Attr("avatarKey")]
        public string avatarKey { get; set; }

        [Attr("givenName")]
        public string givenName { get; set; }

        [Attr("familyName")]
        public string familyName { get; set; }

        [Attr("email")]
        public string email { get; set; }

        [Attr("birthDate")]
        public DateTime birthDate { get; set; }

        [Attr("cellPhone")]
        public string cellPhone { get; set; }

        [Attr("gender")]
        public string gender { get; set; }

        [Attr("password")]
        public string password { get; set; }

        [Attr("citizenshipID")]
        public string citizenshipID { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime updatedAt { get; set; }

        [Attr("isValidated")]
        public bool isValidated { get; set; }
    }
}
