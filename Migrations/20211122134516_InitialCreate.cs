using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace curriculoapi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curriculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Endereco = table.Column<string>(type: "text", nullable: false),
                    Nacionalidade = table.Column<string>(type: "text", nullable: false),
                    Naturalidade = table.Column<string>(type: "text", nullable: false),
                    EstadoCivil = table.Column<string>(type: "text", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Telefone = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Resumo = table.Column<string>(type: "text", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    CargoPretendido = table.Column<string>(type: "text", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    Cidade = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curriculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Experiencias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeEmpresa = table.Column<string>(type: "text", nullable: false),
                    AnoInicio = table.Column<int>(type: "integer", nullable: false),
                    MesInicio = table.Column<int>(type: "integer", nullable: false),
                    AnoFinal = table.Column<int>(type: "integer", nullable: false),
                    MesFinal = table.Column<int>(type: "integer", nullable: false),
                    Atividades = table.Column<string>(type: "text", nullable: false),
                    CurriculoId = table.Column<int>(type: "integer", nullable: false),
                    Cargo = table.Column<string>(type: "text", nullable: false),
                    Atual = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiencias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experiencias_Curriculos_CurriculoId",
                        column: x => x.CurriculoId,
                        principalTable: "Curriculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Formacaos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    CurriculoId = table.Column<int>(type: "integer", nullable: false),
                    NomeFormacao = table.Column<string>(type: "text", nullable: false),
                    Local = table.Column<string>(type: "text", nullable: false),
                    AnoInicio = table.Column<int>(type: "integer", nullable: false),
                    AnoFinal = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formacaos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Formacaos_Curriculos_CurriculoId",
                        column: x => x.CurriculoId,
                        principalTable: "Curriculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Linguas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    Fluencia = table.Column<string>(type: "text", nullable: false),
                    CurriculoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Linguas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Linguas_Curriculos_CurriculoId",
                        column: x => x.CurriculoId,
                        principalTable: "Curriculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tecnologias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeTecnologia = table.Column<string>(type: "text", nullable: false),
                    AutoAvaliacao = table.Column<int>(type: "integer", nullable: false),
                    CurriculoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnologias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tecnologias_Curriculos_CurriculoId",
                        column: x => x.CurriculoId,
                        principalTable: "Curriculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Experiencias_CurriculoId",
                table: "Experiencias",
                column: "CurriculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Formacaos_CurriculoId",
                table: "Formacaos",
                column: "CurriculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Linguas_CurriculoId",
                table: "Linguas",
                column: "CurriculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tecnologias_CurriculoId",
                table: "Tecnologias",
                column: "CurriculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experiencias");

            migrationBuilder.DropTable(
                name: "Formacaos");

            migrationBuilder.DropTable(
                name: "Linguas");

            migrationBuilder.DropTable(
                name: "Tecnologias");

            migrationBuilder.DropTable(
                name: "Curriculos");
        }
    }
}
