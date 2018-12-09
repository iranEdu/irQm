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
                name: "Exam",
                columns: table => new
                {
                    ExamName = table.Column<string>(nullable: true),
                    Shuffle = table.Column<bool>(nullable: false),
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Username = table.Column<string>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    Time = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => new { x.Id, x.Username });
                    table.ForeignKey(
                        name: "FK_Exam_User_Username",
                        column: x => x.Username,
                        principalTable: "User",
                        principalColumn: "UserName",
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
                    LessonName = table.Column<string>(nullable: false),
                    CreatedByUserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LongAnswerQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LongAnswerQuestions_User_CreatedByUserName",
                        column: x => x.CreatedByUserName,
                        principalTable: "User",
                        principalColumn: "UserName",
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
                    Score = table.Column<float>(nullable: false),
                    GainedScore = table.Column<float>(nullable: false),
                    MultiSelections = table.Column<bool>(nullable: false),
                    CreatedByUserName = table.Column<string>(nullable: true),
                    LessonName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultiChoicesQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MultiChoicesQuestions_User_CreatedByUserName",
                        column: x => x.CreatedByUserName,
                        principalTable: "User",
                        principalColumn: "UserName",
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
                    LessonName = table.Column<string>(nullable: false),
                    CreatedByUserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticalQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PracticalQuestions_User_CreatedByUserName",
                        column: x => x.CreatedByUserName,
                        principalTable: "User",
                        principalColumn: "UserName",
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
                    id = table.Column<string>(maxLength: 50, nullable: false),
                    Face = table.Column<string>(nullable: true),
                    Score = table.Column<float>(nullable: false),
                    GainedScore = table.Column<float>(nullable: false),
                    CreatedByUserName = table.Column<string>(nullable: true),
                    LessonName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuzzleQuestions", x => x.id);
                    table.ForeignKey(
                        name: "FK_PuzzleQuestions_User_CreatedByUserName",
                        column: x => x.CreatedByUserName,
                        principalTable: "User",
                        principalColumn: "UserName",
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
                    Score = table.Column<float>(nullable: false),
                    GainedScore = table.Column<float>(nullable: false),
                    UserAnswer = table.Column<string>(nullable: true),
                    CreatedByUserName = table.Column<string>(nullable: true),
                    LessonName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShortAnswerQustions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShortAnswerQustions_User_CreatedByUserName",
                        column: x => x.CreatedByUserName,
                        principalTable: "User",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShortAnswerQustions_Lessons_LessonName",
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
                    ExamUsername = table.Column<string>(nullable: true)
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
                        name: "FK_LongAnswerQuestionInList_Exam_ExamId_ExamUsername",
                        columns: x => new { x.ExamId, x.ExamUsername },
                        principalTable: "Exam",
                        principalColumns: new[] { "Id", "Username" },
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
                        name: "FK_TagInLongAnswer_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
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
                    ExamUsername = table.Column<string>(nullable: true)
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
                        name: "FK_MultiChoicesQuestionInList_Exam_ExamId_ExamUsername",
                        columns: x => new { x.ExamId, x.ExamUsername },
                        principalTable: "Exam",
                        principalColumns: new[] { "Id", "Username" },
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
                        name: "FK_TagInMultichoices_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
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
                    ExamUsername = table.Column<string>(nullable: true)
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
                        name: "FK_PracticalQuestionInList_Exam_ExamId_ExamUsername",
                        columns: x => new { x.ExamId, x.ExamUsername },
                        principalTable: "Exam",
                        principalColumns: new[] { "Id", "Username" },
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
                        name: "FK_TagInPractical_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PuzzleQuestionInList",
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
                    table.PrimaryKey("PK_PuzzleQuestionInList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PuzzleQuestionInList_PuzzleQuestions_Questionid",
                        column: x => x.Questionid,
                        principalTable: "PuzzleQuestions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PuzzleQuestionInList_Exam_ExamId_ExamUsername",
                        columns: x => new { x.ExamId, x.ExamUsername },
                        principalTable: "Exam",
                        principalColumns: new[] { "Id", "Username" },
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
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagInPuzzle_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
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
                    ExamUsername = table.Column<string>(nullable: true)
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
                        name: "FK_ShortAnswerQuestionInList_Exam_ExamId_ExamUsername",
                        columns: x => new { x.ExamId, x.ExamUsername },
                        principalTable: "Exam",
                        principalColumns: new[] { "Id", "Username" },
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
                        name: "FK_TagInShortAnswer_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
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
                    ExamUsername = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TFQuestionInList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TFQuestionInList_Exam_ExamId_ExamUsername",
                        columns: x => new { x.ExamId, x.ExamUsername },
                        principalTable: "Exam",
                        principalColumns: new[] { "Id", "Username" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TFQuestions",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Face = table.Column<string>(nullable: false),
                    CreatedByUserName = table.Column<string>(nullable: true),
                    Score = table.Column<float>(nullable: false),
                    GainedScore = table.Column<float>(nullable: false),
                    FalseOptionId = table.Column<string>(nullable: false),
                    LessonName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TFQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TFQuestions_User_CreatedByUserName",
                        column: x => x.CreatedByUserName,
                        principalTable: "User",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TFQuestions_Lessons_LessonName",
                        column: x => x.LessonName,
                        principalTable: "Lessons",
                        principalColumn: "LessonName",
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
                        name: "FK_TagInTfQuestion_Tag_TagId",
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
                name: "IX_Exam_Username",
                table: "Exam",
                column: "Username");

            migrationBuilder.CreateIndex(
                name: "IX_LongAnswerQuestionInList_QuestionId",
                table: "LongAnswerQuestionInList",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_LongAnswerQuestionInList_ExamId_ExamUsername",
                table: "LongAnswerQuestionInList",
                columns: new[] { "ExamId", "ExamUsername" });

            migrationBuilder.CreateIndex(
                name: "IX_LongAnswerQuestions_CreatedByUserName",
                table: "LongAnswerQuestions",
                column: "CreatedByUserName");

            migrationBuilder.CreateIndex(
                name: "IX_LongAnswerQuestions_LessonName",
                table: "LongAnswerQuestions",
                column: "LessonName");

            migrationBuilder.CreateIndex(
                name: "IX_MultiChoicesQuestionInList_QuestionId",
                table: "MultiChoicesQuestionInList",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiChoicesQuestionInList_ExamId_ExamUsername",
                table: "MultiChoicesQuestionInList",
                columns: new[] { "ExamId", "ExamUsername" });

            migrationBuilder.CreateIndex(
                name: "IX_MultiChoicesQuestions_CreatedByUserName",
                table: "MultiChoicesQuestions",
                column: "CreatedByUserName");

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
                name: "IX_PracticalQuestionInList_ExamId_ExamUsername",
                table: "PracticalQuestionInList",
                columns: new[] { "ExamId", "ExamUsername" });

            migrationBuilder.CreateIndex(
                name: "IX_PracticalQuestions_CreatedByUserName",
                table: "PracticalQuestions",
                column: "CreatedByUserName");

            migrationBuilder.CreateIndex(
                name: "IX_PracticalQuestions_LessonName",
                table: "PracticalQuestions",
                column: "LessonName");

            migrationBuilder.CreateIndex(
                name: "IX_PuzzleQuestionInList_Questionid",
                table: "PuzzleQuestionInList",
                column: "Questionid");

            migrationBuilder.CreateIndex(
                name: "IX_PuzzleQuestionInList_ExamId_ExamUsername",
                table: "PuzzleQuestionInList",
                columns: new[] { "ExamId", "ExamUsername" });

            migrationBuilder.CreateIndex(
                name: "IX_PuzzleQuestions_CreatedByUserName",
                table: "PuzzleQuestions",
                column: "CreatedByUserName");

            migrationBuilder.CreateIndex(
                name: "IX_PuzzleQuestions_LessonName",
                table: "PuzzleQuestions",
                column: "LessonName");

            migrationBuilder.CreateIndex(
                name: "IX_ShortAnswerQuestionInList_QuestionId",
                table: "ShortAnswerQuestionInList",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_ShortAnswerQuestionInList_ExamId_ExamUsername",
                table: "ShortAnswerQuestionInList",
                columns: new[] { "ExamId", "ExamUsername" });

            migrationBuilder.CreateIndex(
                name: "IX_ShortAnswerQustions_CreatedByUserName",
                table: "ShortAnswerQustions",
                column: "CreatedByUserName");

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
                name: "IX_TFQuestionInList_ExamId_ExamUsername",
                table: "TFQuestionInList",
                columns: new[] { "ExamId", "ExamUsername" });

            migrationBuilder.CreateIndex(
                name: "IX_TFQuestions_CreatedByUserName",
                table: "TFQuestions",
                column: "CreatedByUserName");

            migrationBuilder.CreateIndex(
                name: "IX_TFQuestions_FalseOptionId",
                table: "TFQuestions",
                column: "FalseOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_TFQuestions_LessonName",
                table: "TFQuestions",
                column: "LessonName");

            migrationBuilder.AddForeignKey(
                name: "FK_TFQuestionInList_TFQuestions_QuestionId",
                table: "TFQuestionInList",
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
                name: "FK_TFQuestions_User_CreatedByUserName",
                table: "TFQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_TFQuestions_Lessons_LessonName",
                table: "TFQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_TFOption_TFQuestions_Id",
                table: "TFOption");

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
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Exam");

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
