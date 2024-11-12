Feature: Login Functionality

@login @valid_login
Scenario: Successful login with valid credentials
    Given the user is on the Swag Labs login page
    When the user enters valid username "standard_user"
    And the user enters valid password "secret_sauce"
    And the user clicks the login button
    Then the user should be redirected to the products page