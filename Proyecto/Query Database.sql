create table Usuarios(
id int primary key identity(1,1) not null,
Nombre varchar(200) not null,
Departamento varchar(200) not null,
Persona varchar(200) not null,
IP varchar(20)
)

go
create proc sp_agregarUsuario @nom varchar(200), @depto varchar(200), @persona varchar(200), @ip varchar(20)
as
begin
	if (@ip != (select IP from Usuarios where IP = @ip)) or (select count(*) from Usuarios) = 0
		insert into Usuarios values(@nom, @depto, @persona, @ip)
end
go


alter proc sp_modificarIP @nom varchar(200), @ip varchar(20), @anteriorip varchar(20) output
as
begin
	if (select count(*) from Usuarios) != 0
		if @nom = (select Nombre from Usuarios where Nombre = @nom)
		begin
			declare @ipCompare varchar(20)
			select @ipCompare = IP from Usuarios where IP = @ip
			if(@ipCompare is null)
				select @anteriorip = IP from Usuarios where Nombre = @nom
				update Usuarios set ip = @ip where Nombre = @nom
		end
end
go

select * from Usuarios

declare @return varchar(20)
exec sp_modificarIP 'Esteban Chavez', '192.168.200.108', @return output
select @return

drop table Usuarios