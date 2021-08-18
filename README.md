# AssignmentAPI
Enhanced Assignments API
Access using following URL'a

Get Assignment by assignmentId: api/assignment
Get assignment by tagId: api/assignment/GetAssignmentsByTag?tagId=tag3
Get all assignments: api/assignment/GetAssignments
Post an assignment: api/assignment

Sample Assignment JSON:
{
    "AssignmentName": "BioMechanics part1",
    "AssignmentDescription": "BioMechanics session start",
    "AssignmentType": "Major",
    "AssignmentDuration": "40",
    "tags": [
        "tag3",
        "tag1"
    ]
}
