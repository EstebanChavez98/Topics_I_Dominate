create table Usuarios(
id int primary key identity(1,1) not null,
Nombre varchar(200) not null,
Departamento varchar(200) not null,
Persona varchar(200) not null,
IP varchar(20),
Inicio datetime not null,
Final datetime not null
)

go
alter proc sp_agregarUsuario @nom varchar(200), @depto varchar(200), @persona varchar(200), @ip varchar(20), @horas int
as
begin
	declare @fechaFinal datetime
	select @fechaFinal = dateadd(hh,@horas, SYSDATETIME()) 
	insert into Usuarios values(@nom, @depto, @persona, @ip, SYSDATETIME(), @fechaFinal)
end
go

exec sp_agregarUsuario 'Esteban Chavez', 'Gerencia', 'Jorge Felix', '192.168.200.201', 78


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

drop table Usuarios

