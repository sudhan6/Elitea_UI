Feature: Login Functionality
    As a user of Swag Labs
    I want to be able to log in with valid credentials
    So that I can access the products page

@login @valid_login
Scenario: Successful login with valid credentials
    Given I am on the Swag Labs login page
    When I enter the username "standard_user"
    And I enter the password "secret_sauce"
    And I click the login button
    Then I should be redirected to the products page