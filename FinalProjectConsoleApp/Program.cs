
                  Environment.Exit(1);
              }

              // Set up the evaluation context. This context should appear on your LaunchDarkly contexts
              // dashboard soon after you run the demo.
              var context = Context.Builder("example-user-key")
                  .Name("Sandy")
                  .Build();

              var flagValue = client.BoolVariation(FeatureFlagKey, context, false);

              ShowMessage(string.Format("Feature flag '{0}' is {1} for this context",
                  FeatureFlagKey, flagValue));

              // Here we ensure that the SDK shuts down cleanly and has a chance to deliver analytics
              // events to LaunchDarkly before the program exits. If analytics events are not delivered,
              // the context attributes and flag usage statistics will not appear on your dashboard. In
              // a normal long-running application, the SDK would continue running and events would be
              // delivered automatically in the background.
              client.Dispose();
          }
      }
  }