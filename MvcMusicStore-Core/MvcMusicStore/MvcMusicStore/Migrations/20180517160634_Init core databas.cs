using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicStore.Migrations
{
    public partial class Initcoredatabas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 160, nullable: false),
                    LastName = table.Column<string>(maxLength: 160, nullable: false),
                    Address = table.Column<string>(maxLength: 70, nullable: false),
                    City = table.Column<string>(maxLength: 40, nullable: false),
                    State = table.Column<string>(maxLength: 40, nullable: false),
                    PostalCode = table.Column<string>(maxLength: 10, nullable: false),
                    Country = table.Column<string>(maxLength: 40, nullable: false),
                    Phone = table.Column<string>(maxLength: 24, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Total = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GenreId = table.Column<int>(nullable: false),
                    ArtistId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 160, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    AlbumArtUrl = table.Column<string>(maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumId);
                    table.ForeignKey(
                        name: "FK_Albums_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "ArtistId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Albums_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    RecordId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CartId = table.Column<string>(nullable: true),
                    AlbumId = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.RecordId);
                    table.ForeignKey(
                        name: "FK_Carts_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "AlbumId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(nullable: false),
                    AlbumId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "AlbumId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 1, "Aaron Copland & London Symphony Orchestra" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 97, "Nash Ensemble" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 98, "Nicolaus Esterhazy Sinfonia" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 99, "Nirvana" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 100, "O Terço" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 101, "Olodum" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 102, "Orchestra of The Age of Enlightenment" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 96, "Motörhead" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 103, "Os Paralamas Do Sucesso" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 105, "Page & Plant" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 106, "Paul D'Ianno" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 107, "Pearl Jam" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 108, "Pink Floyd" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 109, "Queen" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 110, "R.E.M." });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 104, "Ozzy Osbourne" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 95, "Mötley Crüe" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 94, "Milton Nascimento" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 93, "Miles Davis" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 77, "Led Zeppelin" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 78, "Legião Urbana" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 80, "Les Arts Florissants & William Christie" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 81, "London Symphony Orchestra & Sir Charles Mackerras" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 82, "Luciana Souza/Romero Lubambo" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 83, "Lulu Santos" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 84, "Marcos Valle" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 85, "Marillion" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 86, "Marisa Monte" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 87, "Martin Roscoe" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 88, "Maurizio Pollini" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 89, "Mela Tenenbaum, Pro Musica Prague & Richard Kapp" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 90, "Men At Work" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 91, "Metallica" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 92, "Michael Tilson Thomas & San Francisco Symphony" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 111, "Raul Seixas" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 112, "Red Hot Chili Peppers" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 113, "Roger Norrington, London Classical Players" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 114, "Royal Philharmonic Orchestra & Sir Thomas Beecham" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 134, "The Police" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 135, "The Posies" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 136, "The Rolling Stones" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 137, "The Who" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 138, "Tim Maia" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 139, "Ton Koopman" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 140, "U2" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 141, "UB40" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 142, "Van Halen" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 143, "Various Artists" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 144, "Velvet Revolver" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 145, "Vinícius De Moraes" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 146, "Wilhelm Kempff" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 147, "Yehudi Menuhin" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 148, "Yo-Yo Ma" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 133, "The King's Singers" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 76, "Kiss" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 132, "The Doors" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 130, "The Black Crowes" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 115, "Rush" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 116, "Santana" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 117, "Scholars Baroque Ensemble" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 118, "Scorpions" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 119, "Sergei Prokofiev & Yuri Temirkanov" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 120, "Sir Georg Solti & Wiener Philharmoniker" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 121, "Skank" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 122, "Soundgarden" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 123, "Spyro Gyra" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 124, "Stevie Ray Vaughan & Double Trouble" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 125, "Stone Temple Pilots" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 126, "System Of A Down" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 127, "Temple of the Dog" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 128, "Terry Bozzio, Tony Levin & Steve Stevens" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 129, "The 12 Cellists of The Berlin Philharmonic" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 131, "The Cult" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 75, "Kent Nagano and Orchestre de l'Opéra de Lyon" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 79, "Lenny Kravitz" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 73, "Judas Priest" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 21, "Black Sabbath" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 22, "Boston Symphony Orchestra & Seiji Ozawa" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 23, "Britten Sinfonia, Ivor Bolton & Lesley Garrett" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 24, "Bruce Dickinson" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 25, "Buddy Guy" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 26, "Caetano Veloso" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 27, "Cake" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 28, "Calexico" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 29, "Cássia Eller" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 30, "Chic" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 31, "Chicago Symphony Orchestra & Fritz Reiner" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 32, "Chico Buarque" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 74, "Julian Bream" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 34, "Choir Of Westminster Abbey & Simon Preston" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 35, "Chris Cornell" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 20, "Black Label Society" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 36, "Christopher O'Riley" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 19, "Billy Cobham" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 17, "Berliner Philharmoniker & Hans Rosbaud" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 2, "Aaron Goldberg" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 3, "AC/DC" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 4, "Accept" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 5, "Adrian Leaper & Doreen de Feis" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 6, "Aerosmith" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 7, "Aisha Duo" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 8, "Alanis Morissette" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 9, "Alberto Turco & Nova Schola Gregoriana" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 10, "Alice In Chains" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 11, "Amy Winehouse" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 12, "Anita Ward" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 13, "Antônio Carlos Jobim" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 14, "Apocalyptica" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 15, "Audioslave" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 16, "Barry Wordsworth & BBC Concert Orchestra" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 18, "Berliner Philharmoniker & Herbert Von Karajan" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 37, "Cidade Negra" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 33, "Chico Science & Nação Zumbi" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 39, "Creedence Clearwater Revival" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 59, "Gilberto Gil" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 60, "Godsmack" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 38, "Cláudio Zoli" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 62, "Göteborgs Symfoniker & Neeme Järvi" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 63, "Guns N' Roses" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 64, "Gustav Mahler" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 58, "Gerald Moore" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 65, "Incognito" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 67, "James Levine" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 68, "Jamiroquai" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 69, "Jimi Hendrix" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 70, "Joe Satriani" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 71, "Jorge Ben" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 72, "Jota Quest" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 66, "Iron Maiden" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 57, "Funk Como Le Gusta" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 61, "Gonzaguinha" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 55, "Frank Zappa & Captain Beefheart" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 40, "David Coverdale" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 41, "Deep Purple" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 56, "Fretwork" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 43, "Djavan" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 44, "Donna Summer" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 45, "Dread Zeppelin" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 46, "Ed Motta" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 42, "Dennis Chambers" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 48, "Elis Regina" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 49, "English Concert & Trevor Pinnock" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 50, "Eric Clapton" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 51, "Eugene Ormandy" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 52, "Faith No More" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 53, "Falamansa" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 54, "Foo Fighters" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 47, "Edo de Waart & San Francisco Symphony" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "Name" },
                values: new object[] { 8, null, "Reggae" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "Name" },
                values: new object[] { 7, null, "Latin" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "Name" },
                values: new object[] { 6, null, "Blues" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "Name" },
                values: new object[] { 5, null, "Disco" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "Name" },
                values: new object[] { 1, null, "Rock" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "Name" },
                values: new object[] { 3, null, "Metal" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "Name" },
                values: new object[] { 2, null, "Jazz" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "Name" },
                values: new object[] { 9, null, "Pop" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "Name" },
                values: new object[] { 4, null, "Alternative" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "Name" },
                values: new object[] { 10, null, "Classical" });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtistId",
                table: "Albums",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_GenreId",
                table: "Albums",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_AlbumId",
                table: "Carts",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_AlbumId",
                table: "OrderDetails",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
