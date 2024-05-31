Feature: OrangeHRMFeature

A short summary of the feature

@tag1
Scenario:TC_01 Successful login
 Given the user is on the OrangeHRM login page 
  When the user enters valid username <username> and password <password>
  And the user clicks on the login button
  Then the user is redirected to the dashboard page
  Examples: 
  | username | password |
  |    Admin  | admin123 |


 Scenario:TC_02 Unsuccessful login with incorrect credentials
  Given the user is on the OrangeHRM login page
  When the user enters an incorrect <username> and/or <password>
  And the user clicks on the login button
  Then the user sees an invalid error <invalidmsg>
  Examples: 
  | username | password | invalidmsg          |
  | Admin    | admin121 | Invalid credentials |
  | Admin1   | admin123 | Invalid credentials |
  | Admin1   | admin121 | Invalid credentials |


 Scenario:TC_02.1 Verify required field as userId
  Given the user is on the OrangeHRM login page
  When the user enters only <password>
  And the user clicks on the login button
  Then the user sees an error <message>
  Examples: 
  | password | message  |
  | admin123 | Required |


 Scenario: TC_02.2 Verify required field as password
  Given the user is on the OrangeHRM login page
  When the user enters only <username>
  And the user clicks on the login button
  Then the user sees an error <message>
    Examples: 
  | username | message  |
  | Admin | Required |


 Scenario:TC_02.3 Verify required field as userId and password
  Given the user is on the OrangeHRM login page
  When the user clicks on the login button
  Then the user sees an username error <message>
  Then the user sees an password error <message>
   Examples: 
   | message |
   | Required|         

   @Execute
  Scenario: TC_03 Add new employee successfully
    Given the user is logged in and on the Employee List page <username> <password>
    When the user clicks on Add Employee
    And the user enters valid details for the new employee <fname> <mname> <lname>
    And the user clicks the save button
    Then the new employee should be listed in the Employee List <fname> <mname> <lname>
  
  Examples: 
  | username | password | fname    | mname | lname |
  | Admin    | admin123 | srikanth | kumar | asd   |

  @leave
Scenario:TC_04 Employee submits a leave request
  Given the user is logged in and on the Dashboard <username> <password>
  When the user navigates to the Leave section <fromDate> <toDate>
  And the user clicks on "Apply"
  And the user fills out the leave application form
  And the user submits the request
  Then the leave request should be recorded in the system
  And the user sees a confirmation message "Leave request submitted"
    Examples: 
  | username | password | fromDate   | toDate     |
  | Admin    | admin123 | 2024-11-07 | 2024-11-07 |


  @EmpRoles
  Scenario:TC_05 Admin changes an employee's role
  Given the user is logged in and on the Dashboard <username> <password>
  When the admin accesses the User Management section
  And the admin selects an employee to modify
  And the admin changes the role of the employee
  And the admin saves the changes
  Then the system should update the employee's role
  And the admin sees a confirmation message "Role updated successfully"
   Examples: 
  | username | password |
  | Admin    | admin123 |


  



                           
  



