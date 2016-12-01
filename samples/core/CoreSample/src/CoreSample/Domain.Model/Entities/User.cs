using System;
using JetBrains.Annotations;
using Mvc4Sample.Domain.Entities;
using ByndyuSoft.Infrastructure.Domain;

namespace CoreSample.Domain.Model.Entities
{
    public class User : IEntity
    {
        [Obsolete("Only for NH", true)]
        public User()
        {
        }

        public User([NotNull] string name, [NotNull] string email, [NotNull] string login)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");
            if (string.IsNullOrEmpty(email)) throw new ArgumentNullException("email");
            if (string.IsNullOrEmpty(login)) throw new ArgumentNullException("login");

            Name = name;
            Email = email;
            Login = login;
        }

        [NotNull]
        public virtual string Name { get; protected set; }

        [NotNull]
        public virtual string Login { get; protected set; }

        [NotNull]
        public virtual string Email { get; protected set; }

        public virtual int Id { get; set; }
    }
}