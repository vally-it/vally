import { VallyFrontPage } from './app.po';

describe('vally-front App', function() {
  let page: VallyFrontPage;

  beforeEach(() => {
    page = new VallyFrontPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
