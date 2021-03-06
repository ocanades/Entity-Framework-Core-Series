﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentsApplication.Migrations
{
    public partial class FullData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("63f2d497-cb5b-4477-82d1-35cddd823128"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("b3c23a79-7361-4d10-aec0-dc0ee6a89dd0"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("dfaeed91-6680-4551-8aa7-7e43a21dfbf2"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("efd8a5db-2756-475d-a005-3dbc26ca945b"));

            migrationBuilder.InsertData(
                table: "Evaluation",
                columns: new[] { "EvaluationId", "AdditionalExplanation", "Grade", "StudentId" },
                values: new object[,]
                {
                    { new Guid("0de77365-1ebd-425f-83e6-9d006313e6a7"), "First test...", 5, new Guid("660ed4cd-1361-4216-9faa-9636e4df681a") },
                    { new Guid("b790ee5c-9ded-4bc7-97cd-8359bb6fbc7f"), "Second test...", 4, new Guid("660ed4cd-1361-4216-9faa-9636e4df681a") },
                    { new Guid("2de534dd-025c-4704-8807-35bca79db05b"), "First test...", 3, new Guid("410c14e3-e6df-45b8-8c6f-1e19aed675ac") },
                    { new Guid("2d1c94b4-f01b-4ef9-8757-73819ffcb062"), "Last test...", 2, new Guid("4addc421-0937-45cb-b55c-200b45c6caca") }
                });

            migrationBuilder.InsertData(
                table: "StudentSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[,]
                {
                    { new Guid("660ed4cd-1361-4216-9faa-9636e4df681a"), new Guid("7e69e207-5131-4791-9064-57f6d3c47fc8") },
                    { new Guid("660ed4cd-1361-4216-9faa-9636e4df681a"), new Guid("89fc9e5d-74f6-4d2e-ae82-76f2b1decce7") },
                    { new Guid("660ed4cd-1361-4216-9faa-9636e4df681a"), new Guid("9e5f12c2-0aa2-49b0-9db2-7df40fecf9ad") },
                    { new Guid("410c14e3-e6df-45b8-8c6f-1e19aed675ac"), new Guid("fee204f4-a51d-44bb-a3d7-dcc2b5ee5d4f") },
                    { new Guid("410c14e3-e6df-45b8-8c6f-1e19aed675ac"), new Guid("7e69e207-5131-4791-9064-57f6d3c47fc8") },
                    { new Guid("4addc421-0937-45cb-b55c-200b45c6caca"), new Guid("fee204f4-a51d-44bb-a3d7-dcc2b5ee5d4f") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("0de77365-1ebd-425f-83e6-9d006313e6a7"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("2d1c94b4-f01b-4ef9-8757-73819ffcb062"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("2de534dd-025c-4704-8807-35bca79db05b"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("b790ee5c-9ded-4bc7-97cd-8359bb6fbc7f"));

            migrationBuilder.DeleteData(
                table: "StudentSubject",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("410c14e3-e6df-45b8-8c6f-1e19aed675ac"), new Guid("7e69e207-5131-4791-9064-57f6d3c47fc8") });

            migrationBuilder.DeleteData(
                table: "StudentSubject",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("410c14e3-e6df-45b8-8c6f-1e19aed675ac"), new Guid("fee204f4-a51d-44bb-a3d7-dcc2b5ee5d4f") });

            migrationBuilder.DeleteData(
                table: "StudentSubject",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("4addc421-0937-45cb-b55c-200b45c6caca"), new Guid("fee204f4-a51d-44bb-a3d7-dcc2b5ee5d4f") });

            migrationBuilder.DeleteData(
                table: "StudentSubject",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("660ed4cd-1361-4216-9faa-9636e4df681a"), new Guid("7e69e207-5131-4791-9064-57f6d3c47fc8") });

            migrationBuilder.DeleteData(
                table: "StudentSubject",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("660ed4cd-1361-4216-9faa-9636e4df681a"), new Guid("89fc9e5d-74f6-4d2e-ae82-76f2b1decce7") });

            migrationBuilder.DeleteData(
                table: "StudentSubject",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("660ed4cd-1361-4216-9faa-9636e4df681a"), new Guid("9e5f12c2-0aa2-49b0-9db2-7df40fecf9ad") });

            migrationBuilder.InsertData(
                table: "Evaluation",
                columns: new[] { "EvaluationId", "AdditionalExplanation", "Grade", "StudentId" },
                values: new object[,]
                {
                    { new Guid("dfaeed91-6680-4551-8aa7-7e43a21dfbf2"), "First test...", 5, new Guid("660ed4cd-1361-4216-9faa-9636e4df681a") },
                    { new Guid("63f2d497-cb5b-4477-82d1-35cddd823128"), "Second test...", 4, new Guid("660ed4cd-1361-4216-9faa-9636e4df681a") },
                    { new Guid("b3c23a79-7361-4d10-aec0-dc0ee6a89dd0"), "First test...", 3, new Guid("410c14e3-e6df-45b8-8c6f-1e19aed675ac") },
                    { new Guid("efd8a5db-2756-475d-a005-3dbc26ca945b"), "Last test...", 2, new Guid("4addc421-0937-45cb-b55c-200b45c6caca") }
                });
        }
    }
}
