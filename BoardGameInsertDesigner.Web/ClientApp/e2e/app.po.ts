export class AppPage {
  navigateTo() {
    return browser.get("/");
  }

  getMainHeading() {
    return element(by.css("app-root h1")).getText();
  }
}
