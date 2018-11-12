using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace irQm.Migrations
{
    public partial class initialMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    LessonName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.LessonName);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Family = table.Column<string>(nullable: true),
                    Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "LongAnswerQuestions",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Face = table.Column<string>(nullable: false),
                    Score = table.Column<float>(nullable: false),
                    GainedScore = table.Column<float>(nullable: false),
                    Answer = table.Column<string>(nullable: false),
                    LessonName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LongAnswerQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LongAnswerQuestions_Lessons_LessonName",
                        column: x => x.LessonName,
                        principalTable: "Lessons",
                        principalColumn: "LessonName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MultiChoicesQuestions",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Face = table.Column<string>(nullable: false),
                    Score = table.Column<float>(nullable: false),
                    GainedScore = table.Column<float>(nullable: false),
                    MultiSelections = table.Column<bool>(nullable: false),
                    LessonName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultiChoicesQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MultiChoicesQuestions_Lessons_LessonName",
                        column: x => x.LessonName,
                        principalTable: "Lessons",
                        principalColumn: "LessonName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PracticalQuestions",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Face = table.Column<string>(nullable: false),
                    Score = table.Column<float>(nullable: false),
                    GainedScore = table.Column<float>(nullable: false),
                    LessonName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticalQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PracticalQuestions_Lessons_LessonName",
                        column: x => x.LessonName,
                        principalTable: "Lessons",
                        principalColumn: "LessonName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PuzzleQuestions",
                columns: table => new
                {
                    id = table.Column<string>(maxLength: 50, nullable: false),
                    Face = table.Column<string>(nullable: false),
                    Score = table.Column<float>(nullable: false),
                    GainedScore = table.Column<float>(nullable: false),
                    LessonName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuzzleQuestions", x => x.id);
                    table.ForeignKey(
                        name: "FK_PuzzleQuestions_Lessons_LessonName",
                        column: x => x.LessonName,
                        principalTable: "Lessons",
                        principalColumn: "LessonName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShortAnswerQustions",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Face = table.Column<string>(nullable: false),
                    Score = table.Column<float>(nullable: false),
                    GainedScore = table.Column<float>(nullable: false),
                    UserAnswer = table.Column<string>(nullable: true),
                    LessonName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShortAnswerQustions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShortAnswerQustions_Lessons_LessonName",
                        column: x => x.LessonName,
                        principalTable: "Lessons",
                        principalColumn: "LessonName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    ExamName = table.Column<string>(nullable: true),
                    Shuffle = table.Column<bool>(nullable: false),
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    Time = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => new { x.Id, x.Username });
                    table.ForeignKey(
                        name: "FK_Exams_User_UserName",
                        column: x => x.UserName,
                        principalTable: "User",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exams_User_Username",
                        column: x => x.Username,
                        principalTable: "User",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagInQuestion<LongAnswer>",
                columns: table => new
                {
                    TagId = table.Column<string>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagInQuestion<LongAnswer>", x => new { x.TagId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_TagInQuestion<LongAnswer>_LongAnswerQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "LongAnswerQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagInQuestion<LongAnswer>_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Option",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Answered = table.Column<bool>(nullable: false),
                    IsTrue = table.Column<bool>(nullable: false),
                    number = table.Column<byte>(nullable: false),
                    MultiChoicesId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Option", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Option_MultiChoicesQuestions_MultiChoicesId",
                        column: x => x.MultiChoicesId,
                        principalTable: "MultiChoicesQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagInQuestion<MultiChoices>",
                columns: table => new
                {
                    TagId = table.Column<string>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagInQuestion<MultiChoices>", x => new { x.TagId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_TagInQuestion<MultiChoices>_MultiChoicesQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "MultiChoicesQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagInQuestion<MultiChoices>_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagInQuestion<Practical>",
                columns: table => new
                {
                    TagId = table.Column<string>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagInQuestion<Practical>", x => new { x.TagId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_TagInQuestion<Practical>_PracticalQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "PracticalQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagInQuestion<Practical>_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StringPair",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false),
                    PuzzleAnswerPairs = table.Column<string>(nullable: true),
                    PuzzlePairs = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StringPair", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StringPair_PuzzleQuestions_PuzzleAnswerPairs",
                        column: x => x.PuzzleAnswerPairs,
                        principalTable: "PuzzleQuestions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StringPair_PuzzleQuestions_PuzzlePairs",
                        column: x => x.PuzzlePairs,
                        principalTable: "PuzzleQuestions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagInQuestion<Puzzle>",
                columns: table => new
                {
                    TagId = table.Column<string>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagInQuestion<Puzzle>", x => new { x.TagId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_TagInQuestion<Puzzle>_PuzzleQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "PuzzleQuestions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagInQuestion<Puzzle>_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StringItem",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Value = table.Column<string>(nullable: false),
                    PracticalId = table.Column<string>(nullable: true),
                    Puzzleid = table.Column<string>(nullable: true),
                    ShortAnswerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StringItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StringItem_PracticalQuestions_PracticalId",
                        column: x => x.PracticalId,
                        principalTable: "PracticalQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StringItem_PuzzleQuestions_Puzzleid",
                        column: x => x.Puzzleid,
                        principalTable: "PuzzleQuestions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StringItem_ShortAnswerQustions_ShortAnswerId",
                        column: x => x.ShortAnswerId,
                        principalTable: "ShortAnswerQustions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TagInQuestion<ShortAnswer>",
                columns: table => new
                {
                    TagId = table.Column<string>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagInQuestion<ShortAnswer>", x => new { x.TagId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_TagInQuestion<ShortAnswer>_ShortAnswerQustions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "ShortAnswerQustions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagInQuestion<ShortAnswer>_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionInList<LongAnswer>",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Row = table.Column<int>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false),
                    ExamId = table.Column<string>(nullable: true),
                    ExamUsername = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionInList<LongAnswer>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionInList<LongAnswer>_LongAnswerQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "LongAnswerQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionInList<LongAnswer>_Exams_ExamId_ExamUsername",
                        columns: x => new { x.ExamId, x.ExamUsername },
                        principalTable: "Exams",
                        principalColumns: new[] { "Id", "Username" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionInList<MultiChoices>",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Row = table.Column<int>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false),
                    ExamId = table.Column<string>(nullable: true),
                    ExamUsername = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionInList<MultiChoices>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionInList<MultiChoices>_MultiChoicesQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "MultiChoicesQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionInList<MultiChoices>_Exams_ExamId_ExamUsername",
                        columns: x => new { x.ExamId, x.ExamUsername },
                        principalTable: "Exams",
                        principalColumns: new[] { "Id", "Username" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionInList<Practical>",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Row = table.Column<int>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false),
                    ExamId = table.Column<string>(nullable: true),
                    ExamUsername = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionInList<Practical>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionInList<Practical>_PracticalQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "PracticalQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionInList<Practical>_Exams_ExamId_ExamUsername",
                        columns: x => new { x.ExamId, x.ExamUsername },
                        principalTable: "Exams",
                        principalColumns: new[] { "Id", "Username" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionInList<Puzzle>",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Row = table.Column<int>(nullable: false),
                    Questionid = table.Column<string>(nullable: false),
                    ExamId = table.Column<string>(nullable: true),
                    ExamUsername = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionInList<Puzzle>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionInList<Puzzle>_PuzzleQuestions_Questionid",
                        column: x => x.Questionid,
                        principalTable: "PuzzleQuestions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionInList<Puzzle>_Exams_ExamId_ExamUsername",
                        columns: x => new { x.ExamId, x.ExamUsername },
                        principalTable: "Exams",
                        principalColumns: new[] { "Id", "Username" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionInList<ShortAnswer>",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Row = table.Column<int>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false),
                    ExamId = table.Column<string>(nullable: true),
                    ExamUsername = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionInList<ShortAnswer>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionInList<ShortAnswer>_ShortAnswerQustions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "ShortAnswerQustions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionInList<ShortAnswer>_Exams_ExamId_ExamUsername",
                        columns: x => new { x.ExamId, x.ExamUsername },
                        principalTable: "Exams",
                        principalColumns: new[] { "Id", "Username" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionInList<TFQuestion>",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Row = table.Column<int>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false),
                    ExamId = table.Column<string>(nullable: true),
                    ExamUsername = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionInList<TFQuestion>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionInList<TFQuestion>_Exams_ExamId_ExamUsername",
                        columns: x => new { x.ExamId, x.ExamUsername },
                        principalTable: "Exams",
                        principalColumns: new[] { "Id", "Username" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TFQuestions",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Face = table.Column<string>(nullable: false),
                    Score = table.Column<float>(nullable: false),
                    GainedScore = table.Column<float>(nullable: false),
                    FalseOptionId = table.Column<string>(nullable: false),
                    LessonName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TFQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TFQuestions_Lessons_LessonName",
                        column: x => x.LessonName,
                        principalTable: "Lessons",
                        principalColumn: "LessonName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagInQuestion<TFQuestion>",
                columns: table => new
                {
                    TagId = table.Column<string>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagInQuestion<TFQuestion>", x => new { x.TagId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_TagInQuestion<TFQuestion>_TFQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "TFQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagInQuestion<TFQuestion>_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TFOption",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    IsTrue = table.Column<bool>(nullable: false),
                    Answered = table.Column<bool>(nullable: false),
                    number = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TFOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TFOption_TFQuestions_Id",
                        column: x => x.Id,
                        principalTable: "TFQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exams_UserName",
                table: "Exams",
                column: "UserName");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_Username",
                table: "Exams",
                column: "Username");

            migrationBuilder.CreateIndex(
                name: "IX_LongAnswerQuestions_LessonName",
                table: "LongAnswerQuestions",
                column: "LessonName");

            migrationBuilder.CreateIndex(
                name: "IX_MultiChoicesQuestions_LessonName",
                table: "MultiChoicesQuestions",
                column: "LessonName");

            migrationBuilder.CreateIndex(
                name: "IX_Option_MultiChoicesId",
                table: "Option",
                column: "MultiChoicesId");

            migrationBuilder.CreateIndex(
                name: "IX_PracticalQuestions_LessonName",
                table: "PracticalQuestions",
                column: "LessonName");

            migrationBuilder.CreateIndex(
                name: "IX_PuzzleQuestions_LessonName",
                table: "PuzzleQuestions",
                column: "LessonName");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionInList<LongAnswer>_QuestionId",
                table: "QuestionInList<LongAnswer>",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionInList<LongAnswer>_ExamId_ExamUsername",
                table: "QuestionInList<LongAnswer>",
                columns: new[] { "ExamId", "ExamUsername" });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionInList<MultiChoices>_QuestionId",
                table: "QuestionInList<MultiChoices>",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionInList<MultiChoices>_ExamId_ExamUsername",
                table: "QuestionInList<MultiChoices>",
                columns: new[] { "ExamId", "ExamUsername" });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionInList<Practical>_QuestionId",
                table: "QuestionInList<Practical>",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionInList<Practical>_ExamId_ExamUsername",
                table: "QuestionInList<Practical>",
                columns: new[] { "ExamId", "ExamUsername" });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionInList<Puzzle>_Questionid",
                table: "QuestionInList<Puzzle>",
                column: "Questionid");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionInList<Puzzle>_ExamId_ExamUsername",
                table: "QuestionInList<Puzzle>",
                columns: new[] { "ExamId", "ExamUsername" });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionInList<ShortAnswer>_QuestionId",
                table: "QuestionInList<ShortAnswer>",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionInList<ShortAnswer>_ExamId_ExamUsername",
                table: "QuestionInList<ShortAnswer>",
                columns: new[] { "ExamId", "ExamUsername" });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionInList<TFQuestion>_QuestionId",
                table: "QuestionInList<TFQuestion>",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionInList<TFQuestion>_ExamId_ExamUsername",
                table: "QuestionInList<TFQuestion>",
                columns: new[] { "ExamId", "ExamUsername" });

            migrationBuilder.CreateIndex(
                name: "IX_ShortAnswerQustions_LessonName",
                table: "ShortAnswerQustions",
                column: "LessonName");

            migrationBuilder.CreateIndex(
                name: "IX_StringItem_PracticalId",
                table: "StringItem",
                column: "PracticalId");

            migrationBuilder.CreateIndex(
                name: "IX_StringItem_Puzzleid",
                table: "StringItem",
                column: "Puzzleid");

            migrationBuilder.CreateIndex(
                name: "IX_StringItem_ShortAnswerId",
                table: "StringItem",
                column: "ShortAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_StringPair_PuzzleAnswerPairs",
                table: "StringPair",
                column: "PuzzleAnswerPairs");

            migrationBuilder.CreateIndex(
                name: "IX_StringPair_PuzzlePairs",
                table: "StringPair",
                column: "PuzzlePairs");

            migrationBuilder.CreateIndex(
                name: "IX_TagInQuestion<LongAnswer>_QuestionId",
                table: "TagInQuestion<LongAnswer>",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TagInQuestion<MultiChoices>_QuestionId",
                table: "TagInQuestion<MultiChoices>",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TagInQuestion<Practical>_QuestionId",
                table: "TagInQuestion<Practical>",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TagInQuestion<Puzzle>_QuestionId",
                table: "TagInQuestion<Puzzle>",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TagInQuestion<ShortAnswer>_QuestionId",
                table: "TagInQuestion<ShortAnswer>",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TagInQuestion<TFQuestion>_QuestionId",
                table: "TagInQuestion<TFQuestion>",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TFQuestions_FalseOptionId",
                table: "TFQuestions",
                column: "FalseOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_TFQuestions_LessonName",
                table: "TFQuestions",
                column: "LessonName");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionInList<TFQuestion>_TFQuestions_QuestionId",
                table: "QuestionInList<TFQuestion>",
                column: "QuestionId",
                principalTable: "TFQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TFQuestions_TFOption_FalseOptionId",
                table: "TFQuestions",
                column: "FalseOptionId",
                principalTable: "TFOption",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TFQuestions_Lessons_LessonName",
                table: "TFQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_TFOption_TFQuestions_Id",
                table: "TFOption");

            migrationBuilder.DropTable(
                name: "Option");

            migrationBuilder.DropTable(
                name: "QuestionInList<LongAnswer>");

            migrationBuilder.DropTable(
                name: "QuestionInList<MultiChoices>");

            migrationBuilder.DropTable(
                name: "QuestionInList<Practical>");

            migrationBuilder.DropTable(
                name: "QuestionInList<Puzzle>");

            migrationBuilder.DropTable(
                name: "QuestionInList<ShortAnswer>");

            migrationBuilder.DropTable(
                name: "QuestionInList<TFQuestion>");

            migrationBuilder.DropTable(
                name: "StringItem");

            migrationBuilder.DropTable(
                name: "StringPair");

            migrationBuilder.DropTable(
                name: "TagInQuestion<LongAnswer>");

            migrationBuilder.DropTable(
                name: "TagInQuestion<MultiChoices>");

            migrationBuilder.DropTable(
                name: "TagInQuestion<Practical>");

            migrationBuilder.DropTable(
                name: "TagInQuestion<Puzzle>");

            migrationBuilder.DropTable(
                name: "TagInQuestion<ShortAnswer>");

            migrationBuilder.DropTable(
                name: "TagInQuestion<TFQuestion>");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "LongAnswerQuestions");

            migrationBuilder.DropTable(
                name: "MultiChoicesQuestions");

            migrationBuilder.DropTable(
                name: "PracticalQuestions");

            migrationBuilder.DropTable(
                name: "PuzzleQuestions");

            migrationBuilder.DropTable(
                name: "ShortAnswerQustions");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "TFQuestions");

            migrationBuilder.DropTable(
                name: "TFOption");
        }
    }
}
