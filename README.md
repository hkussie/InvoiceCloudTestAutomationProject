# InvoiceCloud Test Automation Project

This automation suite contains a single test and a helper method that helps us execute this test. The test does the following: 
  1. Navigates to this URL: https://the-internet.herokuapp.com/add_remove_elements/
  2. Clicks the "Add Element" button N number of times
  3. Then asserts that there will be N number of "Delete" buttons that is equal to the number of times we clicked the "Add Element" button.

### Helper Method

To dynamically use the ClickElementButton() method, simply pass integer numberOfClicks to determine the number of times to click the "Add Element" button. Then pass selenium IWebElement to get the "Delete" buttons rendered to the UI. 
