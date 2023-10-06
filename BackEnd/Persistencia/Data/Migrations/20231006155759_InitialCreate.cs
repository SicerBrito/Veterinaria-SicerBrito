using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Especie",
                columns: table => new
                {
                    IdEspecie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especie", x => x.IdEspecie);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Laboratorio",
                columns: table => new
                {
                    IdLaboratorio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "VARCHAR(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laboratorio", x => x.IdLaboratorio);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Propietario",
                columns: table => new
                {
                    IdPropietario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreCompleto = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietario", x => x.IdPropietario);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    IdProveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreCompleto = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "VARCHAR(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.IdProveedor);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    IdRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreRol = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.IdRol);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoMovimiento",
                columns: table => new
                {
                    IdTipoMovimiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMovimiento", x => x.IdTipoMovimiento);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id_Usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id_Usuario);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Veterinario",
                columns: table => new
                {
                    IdVeterinario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreCompleto = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "VARCHAR(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Especialidad = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veterinario", x => x.IdVeterinario);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Raza",
                columns: table => new
                {
                    IdRaza = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Especie_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raza", x => x.IdRaza);
                    table.ForeignKey(
                        name: "FK_Raza_Especie_Especie_Id",
                        column: x => x.Especie_Id,
                        principalTable: "Especie",
                        principalColumn: "IdEspecie",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Medicamento",
                columns: table => new
                {
                    IdMedicamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CantidadDisponible = table.Column<int>(type: "int", nullable: false),
                    PrecioUnidad = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Laboratorio_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicamento", x => x.IdMedicamento);
                    table.ForeignKey(
                        name: "FK_Medicamento_Laboratorio_Laboratorio_Id",
                        column: x => x.Laboratorio_Id,
                        principalTable: "Laboratorio",
                        principalColumn: "IdLaboratorio",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Expires = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Revoked = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id_Usuario",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UsuariosRoles",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    RolId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosRoles", x => new { x.UsuarioId, x.RolId });
                    table.ForeignKey(
                        name: "FK_UsuariosRoles_Rol_RolId",
                        column: x => x.RolId,
                        principalTable: "Rol",
                        principalColumn: "IdRol",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuariosRoles_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id_Usuario",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Mascota",
                columns: table => new
                {
                    IdMascota = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaNacimiento = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Propietario_Id = table.Column<int>(type: "int", nullable: false),
                    Especie_Id = table.Column<int>(type: "int", nullable: false),
                    Raza_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascota", x => x.IdMascota);
                    table.ForeignKey(
                        name: "FK_Mascota_Especie_Especie_Id",
                        column: x => x.Especie_Id,
                        principalTable: "Especie",
                        principalColumn: "IdEspecie",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mascota_Propietario_Propietario_Id",
                        column: x => x.Propietario_Id,
                        principalTable: "Propietario",
                        principalColumn: "IdPropietario",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mascota_Raza_Raza_Id",
                        column: x => x.Raza_Id,
                        principalTable: "Raza",
                        principalColumn: "IdRaza",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MedicamentosProveedores",
                columns: table => new
                {
                    IdMedicamentosProveedores = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Medicamento_Id = table.Column<int>(type: "int", nullable: false),
                    Proveedor_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicamentosProveedores", x => x.IdMedicamentosProveedores);
                    table.ForeignKey(
                        name: "FK_MedicamentosProveedores_Medicamento_Medicamento_Id",
                        column: x => x.Medicamento_Id,
                        principalTable: "Medicamento",
                        principalColumn: "IdMedicamento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicamentosProveedores_Proveedor_Proveedor_Id",
                        column: x => x.Proveedor_Id,
                        principalTable: "Proveedor",
                        principalColumn: "IdProveedor",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MovimientoMedicamento",
                columns: table => new
                {
                    IdMovimientoMedicamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Producto_Id = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    FechaMovimiento = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovimientoMedicamento", x => x.IdMovimientoMedicamento);
                    table.ForeignKey(
                        name: "FK_MovimientoMedicamento_Medicamento_Producto_Id",
                        column: x => x.Producto_Id,
                        principalTable: "Medicamento",
                        principalColumn: "IdMedicamento",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cita",
                columns: table => new
                {
                    IdCita = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Mascota_Id = table.Column<int>(type: "int", nullable: false),
                    FechaCita = table.Column<DateTime>(type: "DateTime", nullable: false),
                    MotivoCita = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Veterinario_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cita", x => x.IdCita);
                    table.ForeignKey(
                        name: "FK_Cita_Mascota_Mascota_Id",
                        column: x => x.Mascota_Id,
                        principalTable: "Mascota",
                        principalColumn: "IdMascota",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cita_Veterinario_Veterinario_Id",
                        column: x => x.Veterinario_Id,
                        principalTable: "Veterinario",
                        principalColumn: "IdVeterinario",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DetalleMovimiento",
                columns: table => new
                {
                    IdDetalleMovimiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Producto_Id = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    MovimientoMedicamento_Id = table.Column<int>(type: "int", nullable: false),
                    TipoMovimiento_Id = table.Column<int>(type: "int", nullable: false),
                    PrecioTotal = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleMovimiento", x => x.IdDetalleMovimiento);
                    table.ForeignKey(
                        name: "FK_DetalleMovimiento_Medicamento_Producto_Id",
                        column: x => x.Producto_Id,
                        principalTable: "Medicamento",
                        principalColumn: "IdMedicamento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleMovimiento_MovimientoMedicamento_MovimientoMedicament~",
                        column: x => x.MovimientoMedicamento_Id,
                        principalTable: "MovimientoMedicamento",
                        principalColumn: "IdMovimientoMedicamento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleMovimiento_TipoMovimiento_TipoMovimiento_Id",
                        column: x => x.TipoMovimiento_Id,
                        principalTable: "TipoMovimiento",
                        principalColumn: "IdTipoMovimiento",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TratamientoMedico",
                columns: table => new
                {
                    IdTratamientoMedico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cita_Id = table.Column<int>(type: "int", nullable: false),
                    Medicamento_Id = table.Column<int>(type: "int", nullable: false),
                    CantidadDosis = table.Column<int>(type: "int", nullable: false),
                    CantidadDias = table.Column<int>(type: "int", nullable: false),
                    FechaAdministracion = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Observacion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TratamientoMedico", x => x.IdTratamientoMedico);
                    table.ForeignKey(
                        name: "FK_TratamientoMedico_Cita_Cita_Id",
                        column: x => x.Cita_Id,
                        principalTable: "Cita",
                        principalColumn: "IdCita",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TratamientoMedico_Medicamento_Medicamento_Id",
                        column: x => x.Medicamento_Id,
                        principalTable: "Medicamento",
                        principalColumn: "IdMedicamento",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Especie",
                columns: new[] { "IdEspecie", "Nombre" },
                values: new object[,]
                {
                    { 1, "felina" },
                    { 2, "Perro" },
                    { 3, "Hamster" },
                    { 4, "Conejo" },
                    { 5, "Serpiente" }
                });

            migrationBuilder.InsertData(
                table: "Laboratorio",
                columns: new[] { "IdLaboratorio", "Direccion", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Cl 58 #8-41, Bucaramanga, Girón, Bucaramanga, Santander", "Genfar", "3145674323" },
                    { 2, "Cl. 158, Floridablanca, Santander", "Laboratorio clínico Higuera Escalante", "3165374321" },
                    { 3, "Cra. 24 #154 - 106, Floridablanca, Santander", "Megalab Laboratorio", "3209894353" }
                });

            migrationBuilder.InsertData(
                table: "Propietario",
                columns: new[] { "IdPropietario", "Email", "NombreCompleto", "Telefono" },
                values: new object[,]
                {
                    { 1, "JuanOrdoñez@gmail.com", "Juan Andres Lisarazo Ordoñez", "3224546545" },
                    { 2, "PepitoSalamez@gmail.com", "Pepito Perez Salamez", "3012312312" },
                    { 3, "britodelgado514@gmail.com", "Sicer Andres Brito Gutierrez", "3208818203" }
                });

            migrationBuilder.InsertData(
                table: "Proveedor",
                columns: new[] { "IdProveedor", "Email", "NombreCompleto", "Telefono" },
                values: new object[,]
                {
                    { 1, "Calle José Ortega y Gasset, 40 - loc.", "Pablo Antonio Gimenes Ortega", "3224546545" },
                    { 2, "Calle Vitoshko Lale 16, 1618.", "Juanita Perez Ordoñez", "3012312312" },
                    { 3, "Calle Serrano Galvache, 56.", "Konny Liseth Alucema Torres", "3208818203" }
                });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "IdRol", "NombreRol" },
                values: new object[,]
                {
                    { 1, "Administrador" },
                    { 2, "Gerente" },
                    { 3, "Empleado" },
                    { 4, "Persona" }
                });

            migrationBuilder.InsertData(
                table: "TipoMovimiento",
                columns: new[] { "IdTipoMovimiento", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Recepcion" },
                    { 2, "Envio" },
                    { 3, "Preparacion de pedidos" },
                    { 4, "Intercambio de muelles" }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id_Usuario", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "britodelgado514@gmail.com", "1234", "Sicer Brito" },
                    { 2, "angedeveloper@gmail.com", "12345", "Angelica Morales" },
                    { 3, "lisethtorres969@gmail.com", "123456", "Konny Alucemna" }
                });

            migrationBuilder.InsertData(
                table: "Veterinario",
                columns: new[] { "IdVeterinario", "Email", "Especialidad", "NombreCompleto", "Telefono" },
                values: new object[,]
                {
                    { 1, "EduardoCarrasquilla@gmail.com", "Cirujano", "Juan Eduardo Carrasquilla", "3203453432" },
                    { 2, "JuanAriza@gmail.com", "Rehabilitacion", "Juan Jesus Gutierrez Ariza", "3167194381" },
                    { 3, "angelicamorales@gmail.com", "Fisioterapia", "Maria Angrelica Morales Silva", "3013238789" },
                    { 4, "PepitoGiral@gmail.com", "Oncologia", "Pepito Pelas Giral", "3228878976" }
                });

            migrationBuilder.InsertData(
                table: "Medicamento",
                columns: new[] { "IdMedicamento", "CantidadDisponible", "Laboratorio_Id", "Nombre", "PrecioUnidad" },
                values: new object[,]
                {
                    { 1, 100, 1, "Aspirina", "5000" },
                    { 2, 250, 2, "Paracetamol", "1000" },
                    { 3, 30, 3, "Omeprazol", "10000" }
                });

            migrationBuilder.InsertData(
                table: "Raza",
                columns: new[] { "IdRaza", "Especie_Id", "Nombre" },
                values: new object[,]
                {
                    { 1, 1, "Mamiferos" },
                    { 2, 2, "Aves" },
                    { 3, 3, "Reptiles" }
                });

            migrationBuilder.InsertData(
                table: "Mascota",
                columns: new[] { "IdMascota", "Especie_Id", "FechaNacimiento", "Nombre", "Propietario_Id", "Raza_Id" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pepinill0", 1, 1 },
                    { 2, 3, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sparkles", 2, 2 },
                    { 3, 4, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brillitos", 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "MedicamentosProveedores",
                columns: new[] { "IdMedicamentosProveedores", "Medicamento_Id", "Proveedor_Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "MovimientoMedicamento",
                columns: new[] { "IdMovimientoMedicamento", "Cantidad", "FechaMovimiento", "Producto_Id" },
                values: new object[,]
                {
                    { 1, 20, new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 50, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 3, 10, new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "Cita",
                columns: new[] { "IdCita", "FechaCita", "Mascota_Id", "MotivoCita", "Veterinario_Id" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 24, 5, 35, 0, 0, DateTimeKind.Unspecified), 1, "Lo atropello un carro", 1 },
                    { 2, new DateTime(2024, 1, 24, 14, 35, 0, 0, DateTimeKind.Unspecified), 2, "Le sale mucho moco por la nariz", 1 },
                    { 3, new DateTime(2024, 5, 7, 20, 15, 0, 0, DateTimeKind.Unspecified), 3, "Extraño bulto en el costado del abdomen", 2 }
                });

            migrationBuilder.InsertData(
                table: "DetalleMovimiento",
                columns: new[] { "IdDetalleMovimiento", "Cantidad", "MovimientoMedicamento_Id", "PrecioTotal", "Producto_Id", "TipoMovimiento_Id" },
                values: new object[,]
                {
                    { 1, 6, 1, "60000", 1, 1 },
                    { 2, 2, 2, "10000", 2, 2 },
                    { 3, 10, 3, "100000", 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "TratamientoMedico",
                columns: new[] { "IdTratamientoMedico", "CantidadDias", "CantidadDosis", "Cita_Id", "FechaAdministracion", "Medicamento_Id", "Observacion" },
                values: new object[,]
                {
                    { 1, 30, 800, 1, new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "" },
                    { 2, 15, 1200, 2, new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "" },
                    { 3, 7, 500, 3, new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "" },
                    { 4, 21, 150, 3, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cita_Mascota_Id",
                table: "Cita",
                column: "Mascota_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_Veterinario_Id",
                table: "Cita",
                column: "Veterinario_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleMovimiento_MovimientoMedicamento_Id",
                table: "DetalleMovimiento",
                column: "MovimientoMedicamento_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleMovimiento_Producto_Id",
                table: "DetalleMovimiento",
                column: "Producto_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleMovimiento_TipoMovimiento_Id",
                table: "DetalleMovimiento",
                column: "TipoMovimiento_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Mascota_Especie_Id",
                table: "Mascota",
                column: "Especie_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Mascota_Propietario_Id",
                table: "Mascota",
                column: "Propietario_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Mascota_Raza_Id",
                table: "Mascota",
                column: "Raza_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Medicamento_Laboratorio_Id",
                table: "Medicamento",
                column: "Laboratorio_Id");

            migrationBuilder.CreateIndex(
                name: "IX_MedicamentosProveedores_Medicamento_Id",
                table: "MedicamentosProveedores",
                column: "Medicamento_Id");

            migrationBuilder.CreateIndex(
                name: "IX_MedicamentosProveedores_Proveedor_Id",
                table: "MedicamentosProveedores",
                column: "Proveedor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_MovimientoMedicamento_Producto_Id",
                table: "MovimientoMedicamento",
                column: "Producto_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Raza_Especie_Id",
                table: "Raza",
                column: "Especie_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_UsuarioId",
                table: "RefreshToken",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TratamientoMedico_Cita_Id",
                table: "TratamientoMedico",
                column: "Cita_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TratamientoMedico_Medicamento_Id",
                table: "TratamientoMedico",
                column: "Medicamento_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Email",
                table: "Usuario",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Username",
                table: "Usuario",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosRoles_RolId",
                table: "UsuariosRoles",
                column: "RolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleMovimiento");

            migrationBuilder.DropTable(
                name: "MedicamentosProveedores");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "TratamientoMedico");

            migrationBuilder.DropTable(
                name: "UsuariosRoles");

            migrationBuilder.DropTable(
                name: "MovimientoMedicamento");

            migrationBuilder.DropTable(
                name: "TipoMovimiento");

            migrationBuilder.DropTable(
                name: "Proveedor");

            migrationBuilder.DropTable(
                name: "Cita");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Medicamento");

            migrationBuilder.DropTable(
                name: "Mascota");

            migrationBuilder.DropTable(
                name: "Veterinario");

            migrationBuilder.DropTable(
                name: "Laboratorio");

            migrationBuilder.DropTable(
                name: "Propietario");

            migrationBuilder.DropTable(
                name: "Raza");

            migrationBuilder.DropTable(
                name: "Especie");
        }
    }
}
