import { JSFileSystemTemplatePage } from './app.po';

describe('JSFileSystem App', function() {
  let page: JSFileSystemTemplatePage;

  beforeEach(() => {
    page = new JSFileSystemTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
