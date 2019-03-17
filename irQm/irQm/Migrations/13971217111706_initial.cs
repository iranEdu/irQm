using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace irQm.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    LessonName = table.Column<string>(maxLength: 250, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.LessonName);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    UserId = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Family = table.Column<string>(nullable: true),
                    Role = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    ExamName = table.Column<string>(nullable: true),
                    Shuffle = table.Column<bool>(nullable: false),
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    RegisterTime = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    Time = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => new { x.Id, x.UserId });
                    table.ForeignKey(
                        name: "FK_Exams_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LongAnswerQuestions",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Face = table.Column<string>(nullable: true),
                    Score = table.Column<float>(nullable: false),
                    GainedScore = table.Column<float>(nullable: false),
                    Answer = table.Column<string>(nullable: true),
                    UserAnswer = table.Column<string>(nullable: true),
                    LessonName = table.Column<string>(nullable: false),
                    CreatorUserId = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    RegisterTime = table.Column<DateTime>(nullable: false),
                    EditTime = table.Column<DateTime>(nullable: false),
                    JustInList = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LongAnswerQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LongAnswerQuestions_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
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
                    Face = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    Score = table.Column<float>(nullable: false),
                    GainedScore = table.Column<float>(nullable: false),
                    MultiSelections = table.Column<bool>(nullable: false),
                    CreatorUserId = table.Column<string>(nullable: true),
                    LessonName = table.Column<string>(nullable: false),
                    RegisterTime = table.Column<DateTime>(nullable: false),
                    EditTime = table.Column<DateTime>(nullable: false),
                    JustInList = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultiChoicesQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MultiChoicesQuestions_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
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
                    Face = table.Column<string>(nullable: true),
                    Score = table.Column<float>(nullable: false),
                    GainedScore = table.Column<float>(nullable: false),
                    Image = table.Column<byte[]>(nullable: true),
                    RegisterTime = table.Column<DateTime>(nullable: false),
                    EditTime = table.Column<DateTime>(nullable: false),
                    LessonName = table.Column<string>(nullable: false),
                    CreatorUserId = table.Column<string>(nullable: true),
                    JustInList = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticalQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PracticalQuestions_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
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
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Face = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    Score = table.Column<float>(nullable: false),
                    RegisterTime = table.Column<DateTime>(nullable: false),
                    EditTime = table.Column<DateTime>(nullable: false),
                    GainedScore = table.Column<float>(nullable: false),
                    CreatorUserId = table.Column<string>(nullable: true),
                    JustInList = table.Column<bool>(nullable: false),
                    LessonName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuzzleQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PuzzleQuestions_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
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
                    Face = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    Score = table.Column<float>(nullable: false),
                    GainedScore = table.Column<float>(nullable: false),
                    UserAnswer = table.Column<string>(nullable: true),
                    RegisterTime = table.Column<DateTime>(nullable: false),
                    EditTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<string>(nullable: true),
                    LessonName = table.Column<string>(nullable: false),
                    JustInList = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShortAnswerQustions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShortAnswerQustions_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShortAnswerQustions_Lessons_LessonName",
                        column: x => x.LessonName,
                        principalTable: "Lessons",
                        principalColumn: "LessonName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TFQuestions",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Face = table.Column<string>(nullable: false),
                    CreatorUserId = table.Column<string>(nullable: true),
                    RegisterTime = table.Column<DateTime>(nullable: false),
                    EditTime = table.Column<DateTime>(nullable: false),
                    Score = table.Column<float>(nullable: false),
                    GainedScore = table.Column<float>(nullable: false),
                    TrueOption = table.Column<bool>(nullable: false),
                    FalseOption = table.Column<bool>(nullable: false),
                    AnsweredTrueOption = table.Column<bool>(nullable: false),
                    AnsweredFalseOption = table.Column<bool>(nullable: false),
                    LessonName = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    JustInList = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TFQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TFQuestions_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TFQuestions_Lessons_LessonName",
                        column: x => x.LessonName,
                        principalTable: "Lessons",
                        principalColumn: "LessonName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LongAnswerQuestionInList",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Row = table.Column<int>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false),
                    ExamId = table.Column<string>(nullable: true),
                    ExamUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LongAnswerQuestionInList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LongAnswerQuestionInList_LongAnswerQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "LongAnswerQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LongAnswerQuestionInList_Exams_ExamId_ExamUserId",
                        columns: x => new { x.ExamId, x.ExamUserId },
                        principalTable: "Exams",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagInLongAnswer",
                columns: table => new
                {
                    TagId = table.Column<string>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagInLongAnswer", x => new { x.TagId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_TagInLongAnswer_LongAnswerQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "LongAnswerQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagInLongAnswer_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MultiChoicesQuestionInList",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Row = table.Column<int>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false),
                    ExamId = table.Column<string>(nullable: true),
                    ExamUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultiChoicesQuestionInList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MultiChoicesQuestionInList_MultiChoicesQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "MultiChoicesQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MultiChoicesQuestionInList_Exams_ExamId_ExamUserId",
                        columns: x => new { x.ExamId, x.ExamUserId },
                        principalTable: "Exams",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Option",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Answered = table.Column<bool>(nullable: false),
                    Face = table.Column<string>(nullable: false),
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
                name: "TagInMultichoices",
                columns: table => new
                {
                    TagId = table.Column<string>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagInMultichoices", x => new { x.TagId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_TagInMultichoices_MultiChoicesQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "MultiChoicesQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagInMultichoices_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PracticalQuestionInList",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Row = table.Column<int>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false),
                    ExamId = table.Column<string>(nullable: true),
                    ExamUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticalQuestionInList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PracticalQuestionInList_PracticalQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "PracticalQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PracticalQuestionInList_Exams_ExamId_ExamUserId",
                        columns: x => new { x.ExamId, x.ExamUserId },
                        principalTable: "Exams",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagInPractical",
                columns: table => new
                {
                    TagId = table.Column<string>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagInPractical", x => new { x.TagId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_TagInPractical_PracticalQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "PracticalQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagInPractical_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PuzzleQuestionInList",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Row = table.Column<int>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false),
                    ExamId = table.Column<string>(nullable: true),
                    ExamUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuzzleQuestionInList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PuzzleQuestionInList_PuzzleQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "PuzzleQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PuzzleQuestionInList_Exams_ExamId_ExamUserId",
                        columns: x => new { x.ExamId, x.ExamUserId },
                        principalTable: "Exams",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StringPair",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false),
                    Number = table.Column<byte>(nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StringPair_PuzzleQuestions_PuzzlePairs",
                        column: x => x.PuzzlePairs,
                        principalTable: "PuzzleQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagInPuzzle",
                columns: table => new
                {
                    TagId = table.Column<string>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagInPuzzle", x => new { x.TagId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_TagInPuzzle_PuzzleQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "PuzzleQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagInPuzzle_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShortAnswerQuestionInList",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Row = table.Column<int>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false),
                    ExamId = table.Column<string>(nullable: true),
                    ExamUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShortAnswerQuestionInList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShortAnswerQuestionInList_ShortAnswerQustions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "ShortAnswerQustions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShortAnswerQuestionInList_Exams_ExamId_ExamUserId",
                        columns: x => new { x.ExamId, x.ExamUserId },
                        principalTable: "Exams",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StringItem",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Value = table.Column<string>(nullable: false),
                    Number = table.Column<byte>(nullable: false),
                    PracticalId = table.Column<string>(nullable: true),
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StringItem_ShortAnswerQustions_ShortAnswerId",
                        column: x => x.ShortAnswerId,
                        principalTable: "ShortAnswerQustions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagInShortAnswer",
                columns: table => new
                {
                    TagId = table.Column<string>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagInShortAnswer", x => new { x.TagId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_TagInShortAnswer_ShortAnswerQustions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "ShortAnswerQustions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagInShortAnswer_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagInTfQuestion",
                columns: table => new
                {
                    TagId = table.Column<string>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagInTfQuestion", x => new { x.TagId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_TagInTfQuestion_TFQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "TFQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagInTfQuestion_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TFQuestionInList",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Row = table.Column<int>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false),
                    ExamId = table.Column<string>(nullable: true),
                    ExamUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TFQuestionInList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TFQuestionInList_TFQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "TFQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TFQuestionInList_Exams_ExamId_ExamUserId",
                        columns: x => new { x.ExamId, x.ExamUserId },
                        principalTable: "Exams",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Cascade);
                });

         

            migrationBuilder.CreateIndex(
                name: "IX_Exams_UserId",
                table: "Exams",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LongAnswerQuestionInList_QuestionId",
                table: "LongAnswerQuestionInList",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_LongAnswerQuestionInList_ExamId_ExamUserId",
                table: "LongAnswerQuestionInList",
                columns: new[] { "ExamId", "ExamUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_LongAnswerQuestions_CreatorUserId",
                table: "LongAnswerQuestions",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LongAnswerQuestions_LessonName",
                table: "LongAnswerQuestions",
                column: "LessonName");

            migrationBuilder.CreateIndex(
                name: "IX_MultiChoicesQuestionInList_QuestionId",
                table: "MultiChoicesQuestionInList",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiChoicesQuestionInList_ExamId_ExamUserId",
                table: "MultiChoicesQuestionInList",
                columns: new[] { "ExamId", "ExamUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_MultiChoicesQuestions_CreatorUserId",
                table: "MultiChoicesQuestions",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiChoicesQuestions_LessonName",
                table: "MultiChoicesQuestions",
                column: "LessonName");

            migrationBuilder.CreateIndex(
                name: "IX_Option_MultiChoicesId",
                table: "Option",
                column: "MultiChoicesId");

            migrationBuilder.CreateIndex(
                name: "IX_PracticalQuestionInList_QuestionId",
                table: "PracticalQuestionInList",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_PracticalQuestionInList_ExamId_ExamUserId",
                table: "PracticalQuestionInList",
                columns: new[] { "ExamId", "ExamUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_PracticalQuestions_CreatorUserId",
                table: "PracticalQuestions",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PracticalQuestions_LessonName",
                table: "PracticalQuestions",
                column: "LessonName");

            migrationBuilder.CreateIndex(
                name: "IX_PuzzleQuestionInList_QuestionId",
                table: "PuzzleQuestionInList",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_PuzzleQuestionInList_ExamId_ExamUserId",
                table: "PuzzleQuestionInList",
                columns: new[] { "ExamId", "ExamUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_PuzzleQuestions_CreatorUserId",
                table: "PuzzleQuestions",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PuzzleQuestions_LessonName",
                table: "PuzzleQuestions",
                column: "LessonName");

            migrationBuilder.CreateIndex(
                name: "IX_ShortAnswerQuestionInList_QuestionId",
                table: "ShortAnswerQuestionInList",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_ShortAnswerQuestionInList_ExamId_ExamUserId",
                table: "ShortAnswerQuestionInList",
                columns: new[] { "ExamId", "ExamUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_ShortAnswerQustions_CreatorUserId",
                table: "ShortAnswerQustions",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShortAnswerQustions_LessonName",
                table: "ShortAnswerQustions",
                column: "LessonName");

            migrationBuilder.CreateIndex(
                name: "IX_StringItem_PracticalId",
                table: "StringItem",
                column: "PracticalId");

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
                name: "IX_TagInLongAnswer_QuestionId",
                table: "TagInLongAnswer",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TagInMultichoices_QuestionId",
                table: "TagInMultichoices",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TagInPractical_QuestionId",
                table: "TagInPractical",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TagInPuzzle_QuestionId",
                table: "TagInPuzzle",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TagInShortAnswer_QuestionId",
                table: "TagInShortAnswer",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TagInTfQuestion_QuestionId",
                table: "TagInTfQuestion",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TFQuestionInList_QuestionId",
                table: "TFQuestionInList",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TFQuestionInList_ExamId_ExamUserId",
                table: "TFQuestionInList",
                columns: new[] { "ExamId", "ExamUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_TFQuestions_CreatorUserId",
                table: "TFQuestions",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TFQuestions_LessonName",
                table: "TFQuestions",
                column: "LessonName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LongAnswerQuestionInList");

            migrationBuilder.DropTable(
                name: "MultiChoicesQuestionInList");

            migrationBuilder.DropTable(
                name: "Option");

            migrationBuilder.DropTable(
                name: "PracticalQuestionInList");

            migrationBuilder.DropTable(
                name: "PuzzleQuestionInList");

            migrationBuilder.DropTable(
                name: "ShortAnswerQuestionInList");

            migrationBuilder.DropTable(
                name: "StringItem");

            migrationBuilder.DropTable(
                name: "StringPair");

            migrationBuilder.DropTable(
                name: "TagInLongAnswer");

            migrationBuilder.DropTable(
                name: "TagInMultichoices");

            migrationBuilder.DropTable(
                name: "TagInPractical");

            migrationBuilder.DropTable(
                name: "TagInPuzzle");

            migrationBuilder.DropTable(
                name: "TagInShortAnswer");

            migrationBuilder.DropTable(
                name: "TagInTfQuestion");

            migrationBuilder.DropTable(
                name: "TFQuestionInList");

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
                name: "Tags");

            migrationBuilder.DropTable(
                name: "TFQuestions");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
