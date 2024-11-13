Feature: Login Functionality for Swag Labs

  @login
  Scenario: Successful login with valid credentials
    Given the user is on the Swag Labs login page
    When the user enters the username "standard_user"
    And the user enters the password "secret_sauce"
    And the user clicks on the login button
    Then the user is redirected to the products page