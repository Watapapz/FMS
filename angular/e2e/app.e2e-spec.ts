import { FMSTemplatePage } from './app.po';

describe('FMS App', function() {
  let page: FMSTemplatePage;

  beforeEach(() => {
    page = new FMSTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
