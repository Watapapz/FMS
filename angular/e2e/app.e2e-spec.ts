import { FSMTemplatePage } from './app.po';

describe('FSM App', function() {
  let page: FSMTemplatePage;

  beforeEach(() => {
    page = new FSMTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
