using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicalResearch.StudyManagement.Migrations
{
    /// <inheritdoc />
    public partial class V003 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SmsResearchStudies_SmsSystemEndpoints_OriginWdrEndpointUid",
                table: "SmsResearchStudies");

            migrationBuilder.DropTable(
                name: "SmsInstituteRelatedSystemAssignments");

            migrationBuilder.DropTable(
                name: "SmsStudyRelatedSystemAssignments");

            migrationBuilder.DropTable(
                name: "SmsSystemConnections");

            migrationBuilder.DropTable(
                name: "SmsSiteRelatedSystemAssignments");

            migrationBuilder.DropTable(
                name: "SmsSystemEndpoints");

            migrationBuilder.DropIndex(
                name: "IX_SmsResearchStudies_OriginWdrEndpointUid",
                table: "SmsResearchStudies");

            migrationBuilder.DropColumn(
                name: "OriginWdrEndpointUid",
                table: "SmsResearchStudies");

            migrationBuilder.AddColumn<string>(
                name: "DedicatedBdrUrl",
                table: "SmsSites",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DedicatedSdrUrl",
                table: "SmsSites",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DedicatedVdrUrl",
                table: "SmsSites",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BdrUrl",
                table: "SmsResearchStudies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImsUrl",
                table: "SmsResearchStudies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SdrUrl",
                table: "SmsResearchStudies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VdrUrl",
                table: "SmsResearchStudies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WdrUrl",
                table: "SmsResearchStudies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrivateBdrUrl",
                table: "SmsInstitutes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrivateSdrUrl",
                table: "SmsInstitutes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrivateVdrUrl",
                table: "SmsInstitutes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrivateWdrUrl",
                table: "SmsInstitutes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SmsDataEndpoints",
                columns: table => new
                {
                    Url = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerInstituteUid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublicResolvable = table.Column<bool>(type: "bit", nullable: false),
                    EndpointType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OAuthUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsDataEndpoints", x => x.Url);
                    table.ForeignKey(
                        name: "FK_SmsDataEndpoints_SmsInstitutes_OwnerInstituteUid",
                        column: x => x.OwnerInstituteUid,
                        principalTable: "SmsInstitutes",
                        principalColumn: "InstituteUid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SmsInstitueRelatedOAuthConfigs",
                columns: table => new
                {
                    InstituteUid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataEndpointUrl = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OAuthClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OAuthClientSecret = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OAuthScopesRequired = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsInstitueRelatedOAuthConfigs", x => new { x.InstituteUid, x.DataEndpointUrl });
                    table.ForeignKey(
                        name: "FK_SmsInstitueRelatedOAuthConfigs_SmsDataEndpoints_DataEndpointUrl",
                        column: x => x.DataEndpointUrl,
                        principalTable: "SmsDataEndpoints",
                        principalColumn: "Url",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SmsInstitueRelatedOAuthConfigs_SmsInstitutes_InstituteUid",
                        column: x => x.InstituteUid,
                        principalTable: "SmsInstitutes",
                        principalColumn: "InstituteUid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SmsDataEndpoints_OwnerInstituteUid",
                table: "SmsDataEndpoints",
                column: "OwnerInstituteUid");

            migrationBuilder.CreateIndex(
                name: "IX_SmsInstitueRelatedOAuthConfigs_DataEndpointUrl",
                table: "SmsInstitueRelatedOAuthConfigs",
                column: "DataEndpointUrl");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SmsInstitueRelatedOAuthConfigs");

            migrationBuilder.DropTable(
                name: "SmsDataEndpoints");

            migrationBuilder.DropColumn(
                name: "DedicatedBdrUrl",
                table: "SmsSites");

            migrationBuilder.DropColumn(
                name: "DedicatedSdrUrl",
                table: "SmsSites");

            migrationBuilder.DropColumn(
                name: "DedicatedVdrUrl",
                table: "SmsSites");

            migrationBuilder.DropColumn(
                name: "BdrUrl",
                table: "SmsResearchStudies");

            migrationBuilder.DropColumn(
                name: "ImsUrl",
                table: "SmsResearchStudies");

            migrationBuilder.DropColumn(
                name: "SdrUrl",
                table: "SmsResearchStudies");

            migrationBuilder.DropColumn(
                name: "VdrUrl",
                table: "SmsResearchStudies");

            migrationBuilder.DropColumn(
                name: "WdrUrl",
                table: "SmsResearchStudies");

            migrationBuilder.DropColumn(
                name: "PrivateBdrUrl",
                table: "SmsInstitutes");

            migrationBuilder.DropColumn(
                name: "PrivateSdrUrl",
                table: "SmsInstitutes");

            migrationBuilder.DropColumn(
                name: "PrivateVdrUrl",
                table: "SmsInstitutes");

            migrationBuilder.DropColumn(
                name: "PrivateWdrUrl",
                table: "SmsInstitutes");

            migrationBuilder.AddColumn<Guid>(
                name: "OriginWdrEndpointUid",
                table: "SmsResearchStudies",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SmsSystemEndpoints",
                columns: table => new
                {
                    SystemEndpointUid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProviderInstituteUid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApprovedCert = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvailableRoles = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsSystemEndpoints", x => x.SystemEndpointUid);
                    table.ForeignKey(
                        name: "FK_SmsSystemEndpoints_SmsInstitutes_ProviderInstituteUid",
                        column: x => x.ProviderInstituteUid,
                        principalTable: "SmsInstitutes",
                        principalColumn: "InstituteUid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SmsInstituteRelatedSystemAssignments",
                columns: table => new
                {
                    InstituteRelatedSystemAssignemntUid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstituteUid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SystemEndpointUid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomRoles = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UseAsCandidateSdr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UseAsConsumingExternalWdr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UseAsOwnPatientSdr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UseAsOwnWdr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsInstituteRelatedSystemAssignments", x => x.InstituteRelatedSystemAssignemntUid);
                    table.ForeignKey(
                        name: "FK_SmsInstituteRelatedSystemAssignments_SmsInstitutes_InstituteUid",
                        column: x => x.InstituteUid,
                        principalTable: "SmsInstitutes",
                        principalColumn: "InstituteUid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SmsInstituteRelatedSystemAssignments_SmsSystemEndpoints_SystemEndpointUid",
                        column: x => x.SystemEndpointUid,
                        principalTable: "SmsSystemEndpoints",
                        principalColumn: "SystemEndpointUid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SmsSiteRelatedSystemAssignments",
                columns: table => new
                {
                    SiteRelatedSystemAssignmentUid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiteUid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SystemEndpointUid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomRoles = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsSiteRelatedSystemAssignments", x => x.SiteRelatedSystemAssignmentUid);
                    table.ForeignKey(
                        name: "FK_SmsSiteRelatedSystemAssignments_SmsSites_SiteUid",
                        column: x => x.SiteUid,
                        principalTable: "SmsSites",
                        principalColumn: "SiteUid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SmsSiteRelatedSystemAssignments_SmsSystemEndpoints_SystemEndpointUid",
                        column: x => x.SystemEndpointUid,
                        principalTable: "SmsSystemEndpoints",
                        principalColumn: "SystemEndpointUid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SmsStudyRelatedSystemAssignments",
                columns: table => new
                {
                    StudyRelatedSystemAssignmentUid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResearchStudyUid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SystemEndpointUid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomRoles = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsStudyRelatedSystemAssignments", x => x.StudyRelatedSystemAssignmentUid);
                    table.ForeignKey(
                        name: "FK_SmsStudyRelatedSystemAssignments_SmsResearchStudies_ResearchStudyUid",
                        column: x => x.ResearchStudyUid,
                        principalTable: "SmsResearchStudies",
                        principalColumn: "ResearchStudyUid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SmsStudyRelatedSystemAssignments_SmsSystemEndpoints_SystemEndpointUid",
                        column: x => x.SystemEndpointUid,
                        principalTable: "SmsSystemEndpoints",
                        principalColumn: "SystemEndpointUid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SmsSystemConnections",
                columns: table => new
                {
                    SystemConnectionUid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DedicatedSiteRelatedSystemAssignmentUid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OwnerInstituteUid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetSystemEndpointUid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HierSpäterJWTSEttings = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsSystemConnections", x => x.SystemConnectionUid);
                    table.ForeignKey(
                        name: "FK_SmsSystemConnections_SmsInstitutes_OwnerInstituteUid",
                        column: x => x.OwnerInstituteUid,
                        principalTable: "SmsInstitutes",
                        principalColumn: "InstituteUid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SmsSystemConnections_SmsSiteRelatedSystemAssignments_DedicatedSiteRelatedSystemAssignmentUid",
                        column: x => x.DedicatedSiteRelatedSystemAssignmentUid,
                        principalTable: "SmsSiteRelatedSystemAssignments",
                        principalColumn: "SiteRelatedSystemAssignmentUid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SmsSystemConnections_SmsSystemEndpoints_TargetSystemEndpointUid",
                        column: x => x.TargetSystemEndpointUid,
                        principalTable: "SmsSystemEndpoints",
                        principalColumn: "SystemEndpointUid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SmsResearchStudies_OriginWdrEndpointUid",
                table: "SmsResearchStudies",
                column: "OriginWdrEndpointUid");

            migrationBuilder.CreateIndex(
                name: "IX_SmsInstituteRelatedSystemAssignments_InstituteUid",
                table: "SmsInstituteRelatedSystemAssignments",
                column: "InstituteUid");

            migrationBuilder.CreateIndex(
                name: "IX_SmsInstituteRelatedSystemAssignments_SystemEndpointUid",
                table: "SmsInstituteRelatedSystemAssignments",
                column: "SystemEndpointUid");

            migrationBuilder.CreateIndex(
                name: "IX_SmsSiteRelatedSystemAssignments_SiteUid",
                table: "SmsSiteRelatedSystemAssignments",
                column: "SiteUid");

            migrationBuilder.CreateIndex(
                name: "IX_SmsSiteRelatedSystemAssignments_SystemEndpointUid",
                table: "SmsSiteRelatedSystemAssignments",
                column: "SystemEndpointUid");

            migrationBuilder.CreateIndex(
                name: "IX_SmsStudyRelatedSystemAssignments_ResearchStudyUid",
                table: "SmsStudyRelatedSystemAssignments",
                column: "ResearchStudyUid");

            migrationBuilder.CreateIndex(
                name: "IX_SmsStudyRelatedSystemAssignments_SystemEndpointUid",
                table: "SmsStudyRelatedSystemAssignments",
                column: "SystemEndpointUid");

            migrationBuilder.CreateIndex(
                name: "IX_SmsSystemConnections_DedicatedSiteRelatedSystemAssignmentUid",
                table: "SmsSystemConnections",
                column: "DedicatedSiteRelatedSystemAssignmentUid");

            migrationBuilder.CreateIndex(
                name: "IX_SmsSystemConnections_OwnerInstituteUid",
                table: "SmsSystemConnections",
                column: "OwnerInstituteUid");

            migrationBuilder.CreateIndex(
                name: "IX_SmsSystemConnections_TargetSystemEndpointUid",
                table: "SmsSystemConnections",
                column: "TargetSystemEndpointUid");

            migrationBuilder.CreateIndex(
                name: "IX_SmsSystemEndpoints_ProviderInstituteUid",
                table: "SmsSystemEndpoints",
                column: "ProviderInstituteUid");

            migrationBuilder.AddForeignKey(
                name: "FK_SmsResearchStudies_SmsSystemEndpoints_OriginWdrEndpointUid",
                table: "SmsResearchStudies",
                column: "OriginWdrEndpointUid",
                principalTable: "SmsSystemEndpoints",
                principalColumn: "SystemEndpointUid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
