using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace MedicalResearch.StudyManagement.Model {

public class Institute {

  /// <summary> An <see href="https://de.wikipedia.org/wiki/Universally_Unique_Identifier">Universally Unique Identifier</see> which can be generated by any origin system and is used to address this ORSCF conform data record in decentralized environments. Note that this Identity must not be changed any more! </summary>
  [Required]
  public Guid InstituteUid { get; set; } = Guid.NewGuid();

  /// <summary> An DisplayLabel which is dedicated for the usage within the frontend of study managent software. Note that this short name representation hat the caracter of an internal shortcurt and could be ambiguous. The usage for legal-relevant/official communication or documents is not recommended, as well as the usage for technical identification of this record. *this field has a max length of 100 </summary>
  [MaxLength(100), Required]
  public String DisplayLabel { get; set; }

  [Required]
  public Boolean IsArchived { get; set; }

}

/// <summary> entity, which relates to <see href="https://www.hl7.org/fhir/researchstudy.html">HL7.ResearchStudy</see> </summary>
public class ResearchStudy {

  /// <summary> An <see href="https://de.wikipedia.org/wiki/Universally_Unique_Identifier">Universally Unique Identifier</see> which can be generated by any origin system and is used to address this ORSCF conform data record in decentralized environments. Note that this Identity must not be changed any more! </summary>
  [Required]
  public Guid ResearchStudyUid { get; set; } = Guid.NewGuid();

  /// <summary> An DisplayLabel which is dedicated for the usage within the frontend of study managent software. Note that this short name representation hat the caracter of an internal shortcurt and could be ambiguous. The usage for legal-relevant/official communication or documents is not recommended, as well as the usage for technical identification of this record. *this field has a max length of 100 </summary>
  [MaxLength(100), Required]
  public String DisplayLabel { get; set; }

  [Required]
  public Guid InitiatorInstituteUid { get; set; }

  [Required]
  public String StudyWorkflowName { get; set; }

  [Required]
  public String StudyWorkflowVersion { get; set; }

  /// <summary> AS DECLARED BY <see href="https://www.hl7.org/fhir/valueset-research-study-phase.html">HL7.ResearchStudyPhase</see>:
  /// n-a | early-phase-1 | phase-1 | phase-1-phase-2 | phase-2 | phase-2-phase-3 | phase-3 | phase-4 *this field is optional (use null as value) </summary>
  public String Phase { get; set; }

  /// <summary> a estimated date in future is possible *this field is optional </summary>
  public Nullable<DateTime> StartDate { get; set; }

  /// <summary> a estimated date in future is possible *this field is optional </summary>
  public Nullable<DateTime> TerminationDate { get; set; }

  /// <summary> A title which informs about the sematic of the SubjectIdentifer (which concrete value is used): "Randomization-Number", "Screening-Number", ... </summary>
  [Required]
  public String SubjectIdentifierTitle { get; set; }

  /// <summary> AS DECLARED BY <see href="https://www.hl7.org/fhir/valueset-research-study-status.html">HL7.ResearchStudyStatus</see>:
  /// active | administratively-completed | approved | closed-to-accrual | closed-to-accrual-and-intervention | completed | disapproved | in-review | temporarily-closed-to-accrual | temporarily-closed-to-accrual-and-intervention | withdrawn </summary>
  [Required]
  public String Status { get; set; }

  /// <summary> *this field is optional (use null as value) </summary>
  public String TerminatedReason { get; set; }

  [Required]
  public Boolean IsArchived { get; set; }

  /// <summary> *this field is optional (use null as value) </summary>
  public String InitiatorRelatedProjectNumber { get; set; }

  /// <summary> *this field is optional </summary>
  public Nullable<Guid> OriginWdrEndpointUid { get; set; }

}

public class Site {

  /// <summary> An <see href="https://de.wikipedia.org/wiki/Universally_Unique_Identifier">Universally Unique Identifier</see> which can be generated by any origin system and is used to address this ORSCF conform data record in decentralized environments. Note that this Identity must not be changed any more! </summary>
  [Required]
  public Guid SiteUid { get; set; } = Guid.NewGuid();

  /// <summary> <see href="https://de.wikipedia.org/wiki/Universally_Unique_Identifier">Universally Unique Identifier</see> of the institute, which is representing this site </summary>
  [Required]
  public Guid RepresentingInstituteUid { get; set; }

  /// <summary> <see href="https://de.wikipedia.org/wiki/Universally_Unique_Identifier">Universally Unique Identifier</see> of the related record </summary>
  [Required]
  public Guid ResearchStudyUid { get; set; }

  /// <summary> a estimated date in future is possible *this field is optional </summary>
  public Nullable<DateTime> EnrollmentDate { get; set; }

  /// <summary> a estimated date in future is possible *this field is optional </summary>
  public Nullable<DateTime> TerminationDate { get; set; }

  /// <summary> *this field is optional (use null as value) </summary>
  public String TerminatedReason { get; set; }

  /// <summary> Offical 'SiteIdentifier' which is unique within the scope of the related study </summary>
  [Required]
  public String StudyRelatedSiteIdentifer { get; set; }

  /// <summary> An DisplayLabel which is dedicated for the usage within the frontend of study managent software. Note that this short name representation hat the caracter of an internal shortcurt and could be ambiguous. The usage for legal-relevant/official communication or documents is not recommended, as well as the usage for technical identification of this record. </summary>
  [Required]
  public String DisplayLabel { get; set; }

  /// <summary> AS DECLARED BY HL7 </summary>
  [Required]
  public String Status { get; set; }

  /// <summary> *this field is optional (use null as value) </summary>
  public String SiteRelatedProjectNumber { get; set; }

}

public class SystemEndpoint {

  [Required]
  public Guid SystemEndpointUid { get; set; } = Guid.NewGuid();

  [Required]
  public Guid ProviderInstituteUid { get; set; }

  [Required]
  public String AvailableRoles { get; set; }

  [Required]
  public String Url { get; set; }

  [Required]
  public String ApprovedCert { get; set; }

  [Required]
  public String IsPublic { get; set; }

  [Required]
  public String Label { get; set; }

}

public class InstituteRelatedSystemAssignment {

  [Required]
  public Guid InstituteRelatedSystemAssignemntUid { get; set; } = Guid.NewGuid();

  [Required]
  public Guid SystemEndpointUid { get; set; }

  [Required]
  public Guid InstituteUid { get; set; }

  [Required]
  public String UseAsOwnPatientSdr { get; set; }

  [Required]
  public String UseAsCandidateSdr { get; set; }

  [Required]
  public String UseAsOwnWdr { get; set; }

  [Required]
  public String UseAsConsumingExternalWdr { get; set; }

  /// <summary> semicolon separated list of custom role-names </summary>
  [Required]
  public String CustomRoles { get; set; }

}

public class SystemConnection {

  [Required]
  public Guid SystemConnectionUid { get; set; } = Guid.NewGuid();

  [Required]
  public Guid OwnerInstituteUid { get; set; }

  [Required]
  public String JwtSettings { get; set; }

  [Required]
  public Guid TargetSystemEndpointUid { get; set; }

  /// <summary> *this field is optional </summary>
  public Nullable<Guid> DedicatedSiteRelatedSystemAssignmentUid { get; set; }

}

public class InvolvedPerson {

  /// <summary> An <see href="https://de.wikipedia.org/wiki/Universally_Unique_Identifier">Universally Unique Identifier</see> which can be generated by any origin system and is used to address this ORSCF conform data record in decentralized environments. Note that this Identity must not be changed any more! </summary>
  [Required]
  public Guid InvolvedPersonUid { get; set; } = Guid.NewGuid();

  /// <summary> *this field is optional (use null as value) </summary>
  public String DisplayLabel { get; set; }

  /// <summary> *this field is optional </summary>
  public Nullable<Guid> EmailAddress { get; set; }

  [Required]
  public Boolean IsArchived { get; set; }

}

public class InvolvementRole {

  /// <summary> An <see href="https://de.wikipedia.org/wiki/Universally_Unique_Identifier">Universally Unique Identifier</see> which can be generated by any origin system and is used to address this ORSCF conform data record in decentralized environments. Note that this Identity must not be changed any more! </summary>
  [Required]
  public Guid InvolvedPersonRoleUid { get; set; } = Guid.NewGuid();

  [Required]
  public Guid ResearchStudyUid { get; set; }

  /// <summary> *this field is optional (use null as value) </summary>
  public String Role { get; set; }

  /// <summary> *this field is optional </summary>
  public Nullable<DateTime> InvolvedFrom { get; set; }

  /// <summary> *this field is optional </summary>
  public Nullable<DateTime> InvolvedUntil { get; set; }

  /// <summary> null indicated a site independent global role *this field is optional </summary>
  public Nullable<Guid> DedicatedToSiteUid { get; set; }

  [Required]
  public Guid InvolvedPersonUid { get; set; }

}

public class StudyRelatedSystemAssignment {

  [Required]
  public Guid StudyRelatedSystemAssignmentUid { get; set; } = Guid.NewGuid();

  [Required]
  public Guid ResearchStudyUid { get; set; }

  [Required]
  public Guid SystemEndpointUid { get; set; }

  /// <summary> semicolon separated list of custom role-names </summary>
  [Required]
  public String CustomRoles { get; set; }

}

public class SiteRelatedSystemAssignment {

  [Required]
  public Guid SiteRelatedSystemAssignmentUid { get; set; } = Guid.NewGuid();

  [Required]
  public Guid SystemEndpointUid { get; set; }

  [Required]
  public Guid SiteUid { get; set; }

  /// <summary> semicolon separated list of custom role-names </summary>
  [Required]
  public String CustomRoles { get; set; }

}

}
