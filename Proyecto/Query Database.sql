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
alter proc sp_agregarUsuario @nom varchar(200), @depto varchar(200), @persona varchar(200), @ip varchar(20), @InicioFecha varchar(20), @InicioHora varchar(20), @FinalFecha varchar(20), @FinalHora varchar(20)
as
begin
	declare @Inic datetime, @Fin datetime, @I varchar(20), @F varchar(20)
	select @I = replace(@InicioFecha, '-', '')
	select @F = replace(@FinalFecha, '-', '')
	select @Inic = convert(datetime, @I+' '+@InicioHora)
	select @Fin = convert(datetime, @F+' '+@FinalHora)
	insert into Usuarios values(@nom, @depto, @persona, @ip, @Inic, @Fin)
end
go

exec sp_agregarUsuario 'Esteban Chavez', 'Gerencia', 'Jorge Felix', '192.168.200.201', '2019-07-13', '12:45', '2019-07-15', '18:32'
go
exec sp_agregarUsuario 'Rosa Andrade', 'Sistemas', 'Antonio Chavez', '192.168.200.111', '2019-07-13', '14:05', '2019-07-13', '14:06'

select * from Usuarios

drop table Usuarios
