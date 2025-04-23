using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class PopularEstados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Acre', 'AC', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Alagoas', 'AL', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Amapá', 'AP', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Amazonas', 'AM', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Bahia', 'BA', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Ceará', 'CE', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Distrito Federal', 'DF', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Espírito Santo', 'ES', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Goiás', 'GO', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Maranhão', 'MA', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Mato Grosso', 'MT', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Mato Grosso do Sul', 'MS', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Minas Gerais', 'MG', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Pará', 'PA', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Paraíba', 'PB', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Paraná', 'PR', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Pernambuco', 'PE', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Piauí', 'PI', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Rio de Janeiro', 'RJ', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Rio Grande do Norte', 'RN', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Rio Grande do Sul', 'RS', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Rondônia', 'RO', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Roraima', 'RR', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Santa Catarina', 'SC', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('São Paulo', 'SP', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Sergipe', 'SE', GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO estado (nome, uf, createat, updateat, isdeleted) VALUES ('Tocantins', 'TO', GETUTCDATE(), NULL, 0);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from estado");
        }
    }
}
