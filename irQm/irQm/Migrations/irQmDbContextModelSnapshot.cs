﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using irQm.BaseCodes;

namespace irQm.Migrations
{
    [DbContext(typeof(irQmDbContext))]
    partial class irQmDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("irQm.BaseCodes.Exam", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50);

                    b.Property<string>("Username");

                    b.Property<string>("ExamName");

                    b.Property<bool>("Shuffle");

                    b.Property<DateTime>("StartTime");

                    b.Property<TimeSpan>("Time");

                    b.HasKey("Id", "Username");

                    b.HasIndex("Username");

                    b.ToTable("Exam");
                });

            modelBuilder.Entity("irQm.BaseCodes.Lesson", b =>
                {
                    b.Property<string>("LessonName")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("LessonName");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("irQm.BaseCodes.LongAnswer", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("Answer");

                    b.Property<string>("CreatedByUserName");

                    b.Property<string>("Face");

                    b.Property<float>("GainedScore");

                    b.Property<string>("LessonName")
                        .IsRequired();

                    b.Property<float>("Score");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserName");

                    b.HasIndex("LessonName");

                    b.ToTable("LongAnswerQuestions");
                });

            modelBuilder.Entity("irQm.BaseCodes.MultiChoices", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("CreatedByUserName");

                    b.Property<string>("Face");

                    b.Property<float>("GainedScore");

                    b.Property<string>("LessonName")
                        .IsRequired();

                    b.Property<bool>("MultiSelections");

                    b.Property<float>("Score");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserName");

                    b.HasIndex("LessonName");

                    b.ToTable("MultiChoicesQuestions");
                });

            modelBuilder.Entity("irQm.BaseCodes.Option", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<bool>("Answered");

                    b.Property<string>("Face")
                        .IsRequired();

                    b.Property<bool>("IsTrue");

                    b.Property<string>("MultiChoicesId");

                    b.Property<byte>("number");

                    b.HasKey("Id");

                    b.HasIndex("MultiChoicesId");

                    b.ToTable("Option");
                });

            modelBuilder.Entity("irQm.BaseCodes.Practical", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("CreatedByUserName");

                    b.Property<string>("Face");

                    b.Property<float>("GainedScore");

                    b.Property<string>("LessonName")
                        .IsRequired();

                    b.Property<float>("Score");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserName");

                    b.HasIndex("LessonName");

                    b.ToTable("PracticalQuestions");
                });

            modelBuilder.Entity("irQm.BaseCodes.Puzzle", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("CreatedByUserName");

                    b.Property<string>("Face");

                    b.Property<float>("GainedScore");

                    b.Property<string>("LessonName")
                        .IsRequired();

                    b.Property<float>("Score");

                    b.HasKey("id");

                    b.HasIndex("CreatedByUserName");

                    b.HasIndex("LessonName");

                    b.ToTable("PuzzleQuestions");
                });

            modelBuilder.Entity("irQm.BaseCodes.QuestionInList<irQm.BaseCodes.LongAnswer>", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("ExamId");

                    b.Property<string>("ExamUsername");

                    b.Property<string>("QuestionId")
                        .IsRequired();

                    b.Property<int>("Row");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("ExamId", "ExamUsername");

                    b.ToTable("LongAnswerQuestionInList");
                });

            modelBuilder.Entity("irQm.BaseCodes.QuestionInList<irQm.BaseCodes.MultiChoices>", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("ExamId");

                    b.Property<string>("ExamUsername");

                    b.Property<string>("QuestionId")
                        .IsRequired();

                    b.Property<int>("Row");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("ExamId", "ExamUsername");

                    b.ToTable("MultiChoicesQuestionInList");
                });

            modelBuilder.Entity("irQm.BaseCodes.QuestionInList<irQm.BaseCodes.Practical>", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("ExamId");

                    b.Property<string>("ExamUsername");

                    b.Property<string>("QuestionId")
                        .IsRequired();

                    b.Property<int>("Row");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("ExamId", "ExamUsername");

                    b.ToTable("PracticalQuestionInList");
                });

            modelBuilder.Entity("irQm.BaseCodes.QuestionInList<irQm.BaseCodes.Puzzle>", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("ExamId");

                    b.Property<string>("ExamUsername");

                    b.Property<string>("Questionid")
                        .IsRequired();

                    b.Property<int>("Row");

                    b.HasKey("Id");

                    b.HasIndex("Questionid");

                    b.HasIndex("ExamId", "ExamUsername");

                    b.ToTable("PuzzleQuestionInList");
                });

            modelBuilder.Entity("irQm.BaseCodes.QuestionInList<irQm.BaseCodes.ShortAnswer>", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("ExamId");

                    b.Property<string>("ExamUsername");

                    b.Property<string>("QuestionId")
                        .IsRequired();

                    b.Property<int>("Row");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("ExamId", "ExamUsername");

                    b.ToTable("ShortAnswerQuestionInList");
                });

            modelBuilder.Entity("irQm.BaseCodes.QuestionInList<irQm.BaseCodes.TFQuestion>", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("ExamId");

                    b.Property<string>("ExamUsername");

                    b.Property<string>("QuestionId")
                        .IsRequired();

                    b.Property<int>("Row");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("ExamId", "ExamUsername");

                    b.ToTable("TFQuestionInList");
                });

            modelBuilder.Entity("irQm.BaseCodes.ShortAnswer", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("CreatedByUserName");

                    b.Property<string>("Face");

                    b.Property<float>("GainedScore");

                    b.Property<string>("LessonName")
                        .IsRequired();

                    b.Property<float>("Score");

                    b.Property<string>("UserAnswer");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserName");

                    b.HasIndex("LessonName");

                    b.ToTable("ShortAnswerQustions");
                });

            modelBuilder.Entity("irQm.BaseCodes.StringItem", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("PracticalId");

                    b.Property<string>("Puzzleid");

                    b.Property<string>("ShortAnswerId");

                    b.Property<string>("Value")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("PracticalId");

                    b.HasIndex("Puzzleid");

                    b.HasIndex("ShortAnswerId");

                    b.ToTable("StringItem");
                });

            modelBuilder.Entity("irQm.BaseCodes.StringPair", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("Key")
                        .IsRequired();

                    b.Property<string>("PuzzleAnswerPairs");

                    b.Property<string>("PuzzlePairs");

                    b.Property<string>("Value")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("PuzzleAnswerPairs");

                    b.HasIndex("PuzzlePairs");

                    b.ToTable("StringPair");
                });

            modelBuilder.Entity("irQm.BaseCodes.Tag", b =>
                {
                    b.Property<string>("Value")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Value");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("irQm.BaseCodes.TagInQuestion<irQm.BaseCodes.LongAnswer>", b =>
                {
                    b.Property<string>("TagId");

                    b.Property<string>("QuestionId");

                    b.HasKey("TagId", "QuestionId");

                    b.HasIndex("QuestionId");

                    b.ToTable("TagInLongAnswer");
                });

            modelBuilder.Entity("irQm.BaseCodes.TagInQuestion<irQm.BaseCodes.MultiChoices>", b =>
                {
                    b.Property<string>("TagId");

                    b.Property<string>("QuestionId");

                    b.HasKey("TagId", "QuestionId");

                    b.HasIndex("QuestionId");

                    b.ToTable("TagInMultichoices");
                });

            modelBuilder.Entity("irQm.BaseCodes.TagInQuestion<irQm.BaseCodes.Practical>", b =>
                {
                    b.Property<string>("TagId");

                    b.Property<string>("QuestionId");

                    b.HasKey("TagId", "QuestionId");

                    b.HasIndex("QuestionId");

                    b.ToTable("TagInPractical");
                });

            modelBuilder.Entity("irQm.BaseCodes.TagInQuestion<irQm.BaseCodes.Puzzle>", b =>
                {
                    b.Property<string>("TagId");

                    b.Property<string>("QuestionId");

                    b.HasKey("TagId", "QuestionId");

                    b.HasIndex("QuestionId");

                    b.ToTable("TagInPuzzle");
                });

            modelBuilder.Entity("irQm.BaseCodes.TagInQuestion<irQm.BaseCodes.ShortAnswer>", b =>
                {
                    b.Property<string>("TagId");

                    b.Property<string>("QuestionId");

                    b.HasKey("TagId", "QuestionId");

                    b.HasIndex("QuestionId");

                    b.ToTable("TagInShortAnswer");
                });

            modelBuilder.Entity("irQm.BaseCodes.TagInQuestion<irQm.BaseCodes.TFQuestion>", b =>
                {
                    b.Property<string>("TagId");

                    b.Property<string>("QuestionId");

                    b.HasKey("TagId", "QuestionId");

                    b.HasIndex("QuestionId");

                    b.ToTable("TagInTfQuestion");
                });

            modelBuilder.Entity("irQm.BaseCodes.TFOption", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50);

                    b.Property<bool>("Answered");

                    b.Property<bool>("IsTrue");

                    b.Property<byte>("number");

                    b.HasKey("Id");

                    b.ToTable("TFOption");
                });

            modelBuilder.Entity("irQm.BaseCodes.TFQuestion", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("CreatedByUserName");

                    b.Property<string>("Face")
                        .IsRequired();

                    b.Property<string>("FalseOptionId")
                        .IsRequired();

                    b.Property<float>("GainedScore");

                    b.Property<string>("LessonName");

                    b.Property<float>("Score");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserName");

                    b.HasIndex("FalseOptionId");

                    b.HasIndex("LessonName");

                    b.ToTable("TFQuestions");
                });

            modelBuilder.Entity("irQm.BaseCodes.User", b =>
                {
                    b.Property<string>("UserName")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("Family");

                    b.Property<string>("Name");

                    b.Property<string>("Password")
                        .HasMaxLength(50);

                    b.Property<int>("Role");

                    b.HasKey("UserName");

                    b.ToTable("User");
                });

            modelBuilder.Entity("irQm.BaseCodes.Exam", b =>
                {
                    b.HasOne("irQm.BaseCodes.User", "User")
                        .WithMany()
                        .HasForeignKey("Username")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("irQm.BaseCodes.LongAnswer", b =>
                {
                    b.HasOne("irQm.BaseCodes.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByUserName")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("irQm.BaseCodes.Lesson", "Lesson")
                        .WithMany("LongAnswers")
                        .HasForeignKey("LessonName")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("irQm.BaseCodes.MultiChoices", b =>
                {
                    b.HasOne("irQm.BaseCodes.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByUserName")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("irQm.BaseCodes.Lesson", "Lesson")
                        .WithMany("Multichices")
                        .HasForeignKey("LessonName")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("irQm.BaseCodes.Option", b =>
                {
                    b.HasOne("irQm.BaseCodes.MultiChoices")
                        .WithMany("Options")
                        .HasForeignKey("MultiChoicesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("irQm.BaseCodes.Practical", b =>
                {
                    b.HasOne("irQm.BaseCodes.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByUserName")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("irQm.BaseCodes.Lesson", "Lesson")
                        .WithMany("Practicals")
                        .HasForeignKey("LessonName")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("irQm.BaseCodes.Puzzle", b =>
                {
                    b.HasOne("irQm.BaseCodes.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByUserName")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("irQm.BaseCodes.Lesson", "Lesson")
                        .WithMany("Puzzles")
                        .HasForeignKey("LessonName")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("irQm.BaseCodes.QuestionInList<irQm.BaseCodes.LongAnswer>", b =>
                {
                    b.HasOne("irQm.BaseCodes.LongAnswer", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("irQm.BaseCodes.Exam")
                        .WithMany("LongAnswerQuestions")
                        .HasForeignKey("ExamId", "ExamUsername")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("irQm.BaseCodes.QuestionInList<irQm.BaseCodes.MultiChoices>", b =>
                {
                    b.HasOne("irQm.BaseCodes.MultiChoices", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("irQm.BaseCodes.Exam")
                        .WithMany("MultiChoicesQuestions")
                        .HasForeignKey("ExamId", "ExamUsername")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("irQm.BaseCodes.QuestionInList<irQm.BaseCodes.Practical>", b =>
                {
                    b.HasOne("irQm.BaseCodes.Practical", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("irQm.BaseCodes.Exam")
                        .WithMany("PracticalQuestions")
                        .HasForeignKey("ExamId", "ExamUsername")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("irQm.BaseCodes.QuestionInList<irQm.BaseCodes.Puzzle>", b =>
                {
                    b.HasOne("irQm.BaseCodes.Puzzle", "Question")
                        .WithMany()
                        .HasForeignKey("Questionid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("irQm.BaseCodes.Exam")
                        .WithMany("PuzzleQuestions")
                        .HasForeignKey("ExamId", "ExamUsername")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("irQm.BaseCodes.QuestionInList<irQm.BaseCodes.ShortAnswer>", b =>
                {
                    b.HasOne("irQm.BaseCodes.ShortAnswer", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("irQm.BaseCodes.Exam")
                        .WithMany("ShortAnswerQuestions")
                        .HasForeignKey("ExamId", "ExamUsername")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("irQm.BaseCodes.QuestionInList<irQm.BaseCodes.TFQuestion>", b =>
                {
                    b.HasOne("irQm.BaseCodes.TFQuestion", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("irQm.BaseCodes.Exam")
                        .WithMany("TFQuestions")
                        .HasForeignKey("ExamId", "ExamUsername")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("irQm.BaseCodes.ShortAnswer", b =>
                {
                    b.HasOne("irQm.BaseCodes.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByUserName")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("irQm.BaseCodes.Lesson", "Lesson")
                        .WithMany("ShortAnswers")
                        .HasForeignKey("LessonName")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("irQm.BaseCodes.StringItem", b =>
                {
                    b.HasOne("irQm.BaseCodes.Practical")
                        .WithMany("CheckList")
                        .HasForeignKey("PracticalId");

                    b.HasOne("irQm.BaseCodes.Puzzle")
                        .WithMany("ExtraAnswers")
                        .HasForeignKey("Puzzleid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("irQm.BaseCodes.ShortAnswer")
                        .WithMany("Answer")
                        .HasForeignKey("ShortAnswerId");
                });

            modelBuilder.Entity("irQm.BaseCodes.StringPair", b =>
                {
                    b.HasOne("irQm.BaseCodes.Puzzle")
                        .WithMany("AnswerPairs")
                        .HasForeignKey("PuzzleAnswerPairs")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("irQm.BaseCodes.Puzzle")
                        .WithMany("Pairs")
                        .HasForeignKey("PuzzlePairs")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("irQm.BaseCodes.TagInQuestion<irQm.BaseCodes.LongAnswer>", b =>
                {
                    b.HasOne("irQm.BaseCodes.LongAnswer", "Question")
                        .WithMany("Tags")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("irQm.BaseCodes.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("irQm.BaseCodes.TagInQuestion<irQm.BaseCodes.MultiChoices>", b =>
                {
                    b.HasOne("irQm.BaseCodes.MultiChoices", "Question")
                        .WithMany("Tags")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("irQm.BaseCodes.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("irQm.BaseCodes.TagInQuestion<irQm.BaseCodes.Practical>", b =>
                {
                    b.HasOne("irQm.BaseCodes.Practical", "Question")
                        .WithMany("Tags")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("irQm.BaseCodes.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("irQm.BaseCodes.TagInQuestion<irQm.BaseCodes.Puzzle>", b =>
                {
                    b.HasOne("irQm.BaseCodes.Puzzle", "Question")
                        .WithMany("Tags")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("irQm.BaseCodes.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("irQm.BaseCodes.TagInQuestion<irQm.BaseCodes.ShortAnswer>", b =>
                {
                    b.HasOne("irQm.BaseCodes.ShortAnswer", "Question")
                        .WithMany("Tags")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("irQm.BaseCodes.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("irQm.BaseCodes.TagInQuestion<irQm.BaseCodes.TFQuestion>", b =>
                {
                    b.HasOne("irQm.BaseCodes.TFQuestion", "Question")
                        .WithMany("Tags")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("irQm.BaseCodes.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("irQm.BaseCodes.TFOption", b =>
                {
                    b.HasOne("irQm.BaseCodes.TFQuestion")
                        .WithOne("TrueOption")
                        .HasForeignKey("irQm.BaseCodes.TFOption", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("irQm.BaseCodes.TFQuestion", b =>
                {
                    b.HasOne("irQm.BaseCodes.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByUserName")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("irQm.BaseCodes.TFOption", "FalseOption")
                        .WithMany()
                        .HasForeignKey("FalseOptionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("irQm.BaseCodes.Lesson", "Lesson")
                        .WithMany("TFQuestions")
                        .HasForeignKey("LessonName")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
