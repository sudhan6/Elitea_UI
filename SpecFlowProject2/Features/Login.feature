Feature: Login Functionality

@login
Scenario: Successful login with valid credentials
    Given I am on the login page
    When I enter valid username and password
    And I click the login button
    Then I should be logged in successfully

@invalid_login
Scenario Outline: Unsuccessful login with invalid credentials
    Given I am on the login page
    When I enter "<username>" and "<password>"
    And I click the login button
    Then I should see an error message

    Examples:
    | username | password |
    | invalid  | invalid  |
    | valid    | invalid  |
    | invalid  | valid    |