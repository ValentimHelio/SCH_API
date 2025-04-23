using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class PopularMunicipio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Estado: Acre (1)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Rio Branco', 1, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Cruzeiro do Sul', 1, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Sena Madureira', 1, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Tarauacá', 1, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Feijó', 1, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Brasiléia', 1, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Plácido de Castro', 1, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Xapuri', 1, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Senador Guiomard', 1, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Mâncio Lima', 1, GETUTCDATE(), NULL, 0);");

            // Estado: Alagoas (2)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Maceió', 2, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Arapiraca', 2, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Rio Largo', 2, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Palmeira dos Índios', 2, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('União dos Palmares', 2, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Penedo', 2, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('São Miguel dos Campos', 2, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Campo Alegre', 2, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Delmiro Gouveia', 2, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Coruripe', 2, GETUTCDATE(), NULL, 0);");

            // Estado: Amapá (3)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Macapá', 3, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Santana', 3, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Laranjal do Jari', 3, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Oiapoque', 3, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Mazagão', 3, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Tartarugalzinho', 3, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Porto Grande', 3, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Pedra Branca do Amapari', 3, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Calçoene', 3, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Itaubal', 3, GETUTCDATE(), NULL, 0);");

            // Estado: Amazonas (4)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Manaus', 4, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Parintins', 4, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Itacoatiara', 4, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Manacapuru', 4, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Coari', 4, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Tefé', 4, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Tabatinga', 4, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Humaitá', 4, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Benjamin Constant', 4, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Iranduba', 4, GETUTCDATE(), NULL, 0);");

            // Estado: Bahia (5)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Salvador', 5, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Feira de Santana', 5, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Vitória da Conquista', 5, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Camaçari', 5, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Juazeiro', 5, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Itabuna', 5, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Lauro de Freitas', 5, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Ilhéus', 5, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Jequié', 5, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Teixeira de Freitas', 5, GETUTCDATE(), NULL, 0);");

            // Estado: Distrito Federal (7)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Brasília', 7, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Ceilândia', 7, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Taguatinga', 7, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Samambaia', 7, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Planaltina', 7, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Recanto das Emas', 7, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Sobradinho', 7, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Gama', 7, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Santa Maria', 7, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('São Sebastião', 7, GETUTCDATE(), NULL, 0);");

            // Estado: Espírito Santo (8)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Serra', 8, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Vila Velha', 8, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Cariacica', 8, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Vitória', 8, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Cachoeiro de Itapemirim', 8, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Linhares', 8, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Colatina', 8, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Aracruz', 8, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Guarapari', 8, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('São Mateus', 8, GETUTCDATE(), NULL, 0);");

            // Estado: Goiás (9)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Goiânia', 9, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Aparecida de Goiânia', 9, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Anápolis', 9, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Rio Verde', 9, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Luziânia', 9, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Águas Lindas de Goiás', 9, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Valparaíso de Goiás', 9, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Trindade', 9, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Senador Canedo', 9, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Formosa', 9, GETUTCDATE(), NULL, 0);");

            // Estado: Maranhão (10)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('São Luís', 10, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Imperatriz', 10, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('São José de Ribamar', 10, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Timon', 10, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Caxias', 10, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Codó', 10, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Paço do Lumiar', 10, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Açailândia', 10, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Bacabal', 10, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Balsas', 10, GETUTCDATE(), NULL, 0);");

            // Estado: Mato Grosso (11)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Cuiabá', 11, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Várzea Grande', 11, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Rondonópolis', 11, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Sinop', 11, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Tangará da Serra', 11, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Cáceres', 11, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Sorriso', 11, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Lucas do Rio Verde', 11, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Primavera do Leste', 11, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Barra do Garças', 11, GETUTCDATE(), NULL, 0);");

            // Estado: Mato Grosso do Sul (12)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Campo Grande', 12, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Dourados', 12, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Três Lagoas', 12, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Corumbá', 12, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Ponta Porã', 12, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Naviraí', 12, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Nova Andradina', 12, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Aquidauana', 12, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Sidrolândia', 12, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Paranaíba', 12, GETUTCDATE(), NULL, 0);");

            // Estado: Minas Gerais (13)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Belo Horizonte', 13, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Uberlândia', 13, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Contagem', 13, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Juiz de Fora', 13, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Betim', 13, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Montes Claros', 13, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Ribeirão das Neves', 13, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Uberaba', 13, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Governador Valadares', 13, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Ipatinga', 13, GETUTCDATE(), NULL, 0);");

            // Estado: Pará (14)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Belém', 14, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Ananindeua', 14, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Santarém', 14, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Marabá', 14, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Parauapebas', 14, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Castanhal', 14, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Abaetetuba', 14, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Cametá', 14, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Tucuruí', 14, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Bragança', 14, GETUTCDATE(), NULL, 0);");

            // Estado: Paraíba (15)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('João Pessoa', 15, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Campina Grande', 15, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Santa Rita', 15, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Patos', 15, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Bayeux', 15, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Sousa', 15, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Cajazeiras', 15, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Guarabira', 15, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Sapé', 15, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Cabedelo', 15, GETUTCDATE(), NULL, 0);");

            // Estado: Paraná (16)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Curitiba', 16, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Londrina', 16, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Maringá', 16, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Ponta Grossa', 16, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Cascavel', 16, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('São José dos Pinhais', 16, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Foz do Iguaçu', 16, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Colombo', 16, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Guarapuava', 16, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Paranaguá', 16, GETUTCDATE(), NULL, 0);");

            // Estado: Pernambuco (17)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Recife', 17, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Jaboatão dos Guararapes', 17, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Olinda', 17, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Caruaru', 17, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Petrolina', 17, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Cabo de Santo Agostinho', 17, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Igarassu', 17, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Abreu e Lima', 17, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('São Lourenço da Mata', 17, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Arcoverde', 17, GETUTCDATE(), NULL, 0);");

            // Estado: Piauí (18)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Teresina', 18, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Parnaíba', 18, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Picos', 18, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Floriano', 18, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('José de Freitas', 18, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Piripiri', 18, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('São Raimundo Nonato', 18, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Campo Maior', 18, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Cocal', 18, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Barras', 18, GETUTCDATE(), NULL, 0);");

            // Estado: Rio de Janeiro (19)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Rio de Janeiro', 19, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Niterói', 19, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Duque de Caxias', 19, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('São Gonçalo', 19, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Nova Iguaçu', 19, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Campos dos Goytacazes', 19, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Volta Redonda', 19, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Angra dos Reis', 19, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Mesquita', 19, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Itaperuna', 19, GETUTCDATE(), NULL, 0);");

            // Estado: Rio Grande do Norte (20)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Natal', 20, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Mossoró', 20, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Parnamirim', 20, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('São Gonçalo do Amarante', 20, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Caicó', 20, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Açu', 20, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Currais Novos', 20, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Santa Cruz', 20, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Canguaretama', 20, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Tangará', 20, GETUTCDATE(), NULL, 0);");

            // Estado: Rio Grande do Sul (21)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Porto Alegre', 21, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Caxias do Sul', 21, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Pelotas', 21, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Santa Maria', 21, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Viamão', 21, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Gravataí', 21, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('São Leopoldo', 21, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Novo Hamburgo', 21, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Alvorada', 21, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Rio Grande', 21, GETUTCDATE(), NULL, 0);");

            // Estado: Rondônia (22)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Porto Velho', 22, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Ji-Paraná', 22, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Ariquemes', 22, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Vilhena', 22, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Cacoal', 22, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Rolim de Moura', 22, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Guajará-Mirim', 22, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Machadinho d’Oeste', 22, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Colorado do Oeste', 22, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('São Francisco do Guaporé', 22, GETUTCDATE(), NULL, 0);");

            // Estado: Roraima (23)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Boa Vista', 23, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Rorainópolis', 23, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Caracaraí', 23, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Mucajaí', 23, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('São João da Baliza', 23, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Iracema', 23, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Normandia', 23, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Uraricoera', 23, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Cantá', 23, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Maimbé', 23, GETUTCDATE(), NULL, 0);");

            // Estado: Santa Catarina (24)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Florianópolis', 24, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Joinville', 24, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Blumenau', 24, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('São José', 24, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Criciúma', 24, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Chapecó', 24, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Lages', 24, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Itajaí', 24, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Tubarão', 24, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Rio do Sul', 24, GETUTCDATE(), NULL, 0);");

            // Estado: São Paulo(25)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('São Paulo', 25, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Guarulhos', 25, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Campinas', 25, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('São Bernardo do Campo', 25, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('São José dos Campos', 25, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Santo André', 25, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Ribeirão Preto', 25, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Osasco', 25, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Sorocaba', 25, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Mauá', 25, GETUTCDATE(), NULL, 0);");

            // Estado: Sergipe (26)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Aracaju', 26, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Nossa Senhora do Socorro', 26, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Lagarto', 26, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Itabaiana', 26, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Estância', 26, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('São Cristóvão', 26, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Barra dos Coqueiros', 26, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Simão Dias', 26, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Indiaroba', 26, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Santo Amaro das Brotas', 26, GETUTCDATE(), NULL, 0);");

            // Estado: Tocantins (27)
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Palmas', 27, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Araguaína', 27, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Gurupi', 27, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Paraíso do Tocantins', 27, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Augustinópolis', 27, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Miracema do Tocantins', 27, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Colinas do Tocantins', 27, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Porto Nacional', 27, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Lajeado', 27, GETUTCDATE(), NULL, 0);");
            migrationBuilder.Sql("INSERT INTO Municipio (Nome, EstadoId, CreateAt, UpdateAt, IsDeleted) VALUES ('Peixe', 27, GETUTCDATE(), NULL, 0);");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Municipio");
        }
    }
}
