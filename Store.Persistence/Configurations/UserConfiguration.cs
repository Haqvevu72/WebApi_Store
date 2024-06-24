using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities.Concrete;

namespace Store.Persistence.Configurations;

public class UserConfiguration: IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);

        builder.HasOne<Role>(u => u.Role)
               .WithMany(r => r.Users)
               .HasForeignKey(u => u.RoleId);

        builder.HasOne<UserToken>(u => u.Token)
               .WithOne(ut => ut.User)
               .HasForeignKey<User>(u => u.TokenId);

        builder.HasData(
            new User { Id = 1, Name = "John", Surname = "Doe", Email = "john.doe@example.com", Password = "Password1", RoleId = 2 },
            new User { Id = 2, Name = "Jane", Surname = "Smith", Email = "jane.smith@example.com", Password = "Password2", RoleId = 3 },
            new User { Id = 3, Name = "Jim", Surname = "Beam", Email = "jim.beam@example.com", Password = "Password3", RoleId = 4 },
            new User { Id = 4, Name = "Jack", Surname = "Daniels", Email = "jack.daniels@example.com", Password = "Password4", RoleId = 2 },
            new User { Id = 5, Name = "Jill", Surname = "Valentine", Email = "jill.valentine@example.com", Password = "Password5", RoleId = 3 },
            new User { Id = 6, Name = "Jake", Surname = "Gyllenhaal", Email = "jake.gyllenhaal@example.com", Password = "Password6", RoleId = 4 },
            new User { Id = 7, Name = "Jessica", Surname = "Jones", Email = "jessica.jones@example.com", Password = "Password7", RoleId = 2 },
            new User { Id = 8, Name = "James", Surname = "Bond", Email = "james.bond@example.com", Password = "Password8", RoleId = 3 },
            new User { Id = 9, Name = "Bruce", Surname = "Wayne", Email = "bruce.wayne@example.com", Password = "Password9", RoleId = 4 },
            new User { Id = 10, Name = "Clark", Surname = "Kent", Email = "clark.kent@example.com", Password = "Password10", RoleId = 2 },
            new User { Id = 11, Name = "Peter", Surname = "Parker", Email = "peter.parker@example.com", Password = "Password11", RoleId = 3 },
            new User { Id = 12, Name = "Tony", Surname = "Stark", Email = "tony.stark@example.com", Password = "Password12", RoleId = 4 },
            new User { Id = 13, Name = "Steve", Surname = "Rogers", Email = "steve.rogers@example.com", Password = "Password13", RoleId = 2 },
            new User { Id = 14, Name = "Natasha", Surname = "Romanoff", Email = "natasha.romanoff@example.com", Password = "Password14", RoleId = 3 },
            new User { Id = 15, Name = "Wanda", Surname = "Maximoff", Email = "wanda.maximoff@example.com", Password = "Password15", RoleId = 4 },
            new User { Id = 16, Name = "Bruce", Surname = "Banner", Email = "bruce.banner@example.com", Password = "Password16", RoleId = 2 },
            new User { Id = 17, Name = "Stephen", Surname = "Strange", Email = "stephen.strange@example.com", Password = "Password17", RoleId = 3 },
            new User { Id = 18, Name = "Scott", Surname = "Lang", Email = "scott.lang@example.com", Password = "Password18", RoleId = 4 },
            new User { Id = 19, Name = "Sam", Surname = "Wilson", Email = "sam.wilson@example.com", Password = "Password19", RoleId = 2 },
            new User { Id = 20, Name = "Bucky", Surname = "Barnes", Email = "bucky.barnes@example.com", Password = "Password20", RoleId = 3 },
            new User { Id = 21,Name = "Elgun" , Surname = "Haqverdiyev" , Email = "Elgun02@gmail.com" , Password = "Elgun123" ,RoleId = 1});
    }
}